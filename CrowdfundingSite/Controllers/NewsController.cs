using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CrowdfundingSite.CloudStorage;
using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Images;
using CrowdfundingSite.Models;
using CrowdfundingSite.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace CrowdfundingSite.Controllers
{

    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        private ICloudStorage cloudStorage;

        public NewsController(DataManager dataManager, ICloudStorage cloudinarySettings)
        {
            this.dataManager = dataManager;
            this.cloudStorage = cloudinarySettings;
        }

        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public IActionResult Add()
        {
            News news = new News();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            SelectList campaignesList = new SelectList(dataManager.СampaignItems.GetAllСampaigns().Where(camp => camp.CreatorId == userId), "Id", "Title");
            ViewBag.Campaigns = campaignesList;
            return View(news);
        }

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public async Task<IActionResult> Add(News model, IFormFile Cover)
        {
            if (ModelState.IsValid)
            {
                string imagePath;
                Uri uri;
                if (Cover != null)
                {
                    imagePath = await Extensions.GetFilePathAsync(Cover);
                    uri = cloudStorage.UploadImage(imagePath);
                    model.ImagePath = uri.ToString();
                    dataManager.News.SaveNew(model);
                }
                dataManager.News.SaveNew(model);
                return Redirect("/Home/Index/");
            }
            return View(model);
        }

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.News.DeleteNew(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
