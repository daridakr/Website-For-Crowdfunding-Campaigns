using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using CrowdfundingSite.Models;
using CrowdfundingSite.Service;
using CrowdfundingSite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IUserService = CrowdfundingSite.Service.IUserService;

namespace CrowdfundingSite.Controllers
{
    // для данной области на сайте действуют правила авторизации
    [Authorize(Roles ="admin, user")]
    public class AccountController : Controller
    {
        // менеджеры для ооперирования пользователями в базе данных
        private readonly UserManager<CrowdUser> userManager;
        private readonly SignInManager<CrowdUser> signInManager;
        private readonly IUserService _userService;

        public AccountController(UserManager<CrowdUser> userMgr, SignInManager<CrowdUser> signinMgr, IUserService userService)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            _userService = userService;
        }

        public IActionResult Account()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("user")) return RedirectToAction("", "User");
                if (User.IsInRole("admin")) return RedirectToAction("","admin");
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        public IActionResult Begin()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("user")) return RedirectToAction("", "User");
                if (User.IsInRole("admin")) return RedirectToAction("", "admin");
            }
            return RedirectToAction("Login", "Account");
        }

        // для того, чтобы войти нужно быть анонимным пользователем
        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            var model = new LoginViewModel
            {
                ReturnIrl = returnUrl,
            };
            ViewBag.returnUrl = returnUrl;
            return View(model);
            // передаем LoginViewModel в качестве модели в представление 
        }

        [Authorize(Roles = "user")]
        [AllowAnonymous]
        public IActionResult GoogleLogin()
        {
            string redirectUrl = Url.Action("GoogleResponse", "Account");
            var properties = signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        [Authorize(Roles = "user")]
        [AllowAnonymous]
        public async Task<IActionResult> GoogleResponse()
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction(nameof(Login));

            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            string[] userInfo = { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };
            if (result.Succeeded)
                return View(userInfo);
            else
            {
                CrowdUser user = new CrowdUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value
                };

                IdentityResult identResult = await userManager.CreateAsync(user);
                if (identResult.Succeeded)
                {
                    identResult = await userManager.AddLoginAsync(user, info);
                    if (identResult.Succeeded)
                    {
                        await signInManager.SignInAsync(user, false);
                        return View(userInfo);
                    }
                }
                return View();
                //return AccessDenied();
            }
        }

        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        // пост версия для Login
        [HttpPost]
        [AllowAnonymous]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            // если все валидно и пользователь ввел те данные, которые мы от него ожидаем
            if (ModelState.IsValid)
            {
                // то ищем пользователя по логину
                CrowdUser user = await userManager.FindByNameAsync(model.UserName);
                // если пользователь найден
                if (user != null)
                {
                    // то делаем выход
                    await signInManager.SignOutAsync();
                    // пытаемся войти по паролю
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false); // false - не блокировать пользователя при неудачной попытке входа
                    if (result.Succeeded)
                    {
                        // если все успешно, перенаправляем пользователя по значению returnUrl
                        return Redirect(returnUrl ?? "/");
                    }
                    else ModelState.AddModelError(nameof(LoginViewModel.UserName), "Вы ввели неверный пароль для данного логина");
                    if (result.IsNotAllowed) ModelState.AddModelError("", "Email не подтверждён");
                }
                // иначе добавляем к модели ошибку
                else ModelState.AddModelError(nameof(LoginViewModel.UserName), "Вы ввели неверный логин");
            }
            // оптправялем модель обратно в бразуер пользователя
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                CrowdUser user = new CrowdUser { Email = model.Email, UserName = model.UserName, UserSurname = model.UserSurname, BirthDay = model.BirthDay };
                // добавляем пользователя в бд
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //// генерируем токен для подтверждения регистрации
                    //var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    //if(!string.IsNullOrEmpty(token))
                    //{

                    //}
                    //// создаем ссылку для подтверждения

                    //var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId=user.Id, code=code }, protocol: HttpContext.Request.Scheme);
                    //// отправка письма
                    //await userManager.SetEmailAsync(user, $"Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>link</a>");
                    //return View("DisplayEmail");
                    
                     // установка куки
                    await signInManager.SignInAsync(user, false);
                    // установка роли
                    await userManager.AddToRoleAsync(user, Config.UserRoleName);
                    return RedirectToAction("Index", "Home");
                     
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        //private async Task SendEmailConfirmationEmail(CrowdUser user, string token)
        //{
        //    UserEmailOptions 
        //}

        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View(new ChangePasswordModel());
        }

        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid) 
            {
                var result = await ChangePasswordAsync(model);
                if (result.Succeeded)
                {
                    ViewBag.IsSuccess = true;
                    ModelState.Clear();
                    return View();
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        private async Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            var userId = _userService.GetUserId();
            var user = await userManager.FindByIdAsync(userId);
            return await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
        }

        [Route("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
