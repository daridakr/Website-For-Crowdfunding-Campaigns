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

namespace CrowdfundingSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CampaignItemsController : Controller
    {
        private readonly DataManager dataManager;
        private ICloudStorage cloudStorage;


        public CampaignItemsController(DataManager dataManager, ICloudStorage cloudinarySettings)
        {
            this.dataManager = dataManager;
            this.cloudStorage = cloudinarySettings;
        }

        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            // ищем кампанию в базе данных
            var entity = id == default ? new Campaign() : dataManager.СampaignItems.GetСampaignById(id);
            SelectList subjects = new SelectList(dataManager.Subjects.GetAllSubjects(), "Id", "Title");
            if (User.IsInRole("admin"))
            {
                SelectList users = new SelectList(dataManager.Users.GetAllUsers(), "Id", "UserName");
                ViewBag.Users = users;
            }
            else
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewBag.CurrentUser = userId;
            }

            ViewBag.Subjects = subjects;
            ViewBag.Tags = dataManager.Tags.GetAllTags();
            return View(entity);
        }

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public async Task<IActionResult> EditAsync(Campaign model, IFormFile Cover, List<IFormFile> Pictures, Guid[] selectedTags)
        {
            if (ModelState.IsValid)
            {
                if (selectedTags != null)
                {
                    model.Tags.Clear();
                    foreach (var tag in dataManager.Tags.GetAllTags().Where(tag => selectedTags.Contains(tag.Id)))
                    {
                        model.Tags.Add(tag);
                    }
                }
                var bonuses = dataManager.BonusItems.GetAllBonuses(model.Id);
                if (bonuses != null)
                {
                    foreach (var bonus in bonuses)
                    {
                        model.Bonuses.Add(bonus);
                    }
                }
                string imagePath;
                Uri uri;
                if (Cover != null)
                {
                    imagePath = await Extensions.GetFilePathAsync(Cover);
                    uri = cloudStorage.UploadImage(imagePath);
                    model.CoverPath = uri.ToString();
                    dataManager.СampaignItems.SaveСampaign(model);
                }
                if (Pictures.Count > 0)
                {
                    CampaignImage campaignImage;
                    foreach (var picture in Pictures)
                    {
                        imagePath = await Extensions.GetFilePathAsync(picture);
                        uri = cloudStorage.UploadImage(imagePath);
                        campaignImage = new CampaignImage();
                        campaignImage.CampaignId = model.Id;
                        campaignImage.ImagePath = uri.ToString();
                        dataManager.CampaignImages.SaveCampaignImage(campaignImage);
                    }
                }
                dataManager.СampaignItems.SaveСampaign(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.СampaignItems.DeleteСampaign(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
