using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var model = new EntitiesViewModel();
            model.Campaigns = dataManager.СampaignItems.GetAllСampaigns();
            model.Users = dataManager.Users.GetAllUsers();
            model.Subjects = dataManager.Subjects.GetAllSubjects();
            model.Tags = dataManager.Tags.GetAllTags();
            /*
            foreach(Campaign campaign in dataManager.СampaignItems.GetAllСampaigns())
            {
                CampaignViewModel campaignViewModel = new CampaignViewModel { Id = campaign.Id,
                    Title = campaign.Title, AverageRating = campaign.AverageRating, Bonus = new Bonus(),
                    Bonuses = campaign.Bonuses, Comments = campaign.Comments, CoverPath = campaign.CoverPath,
                    Creator = campaign.Creator, CreatorId = campaign.CreatorId, DateAdded = campaign.DateAdded,
                    EndDate = campaign.EndDate, Images = campaign.Images, News = campaign.News,
                    RequiredMoneyAmount = campaign.RequiredMoneyAmount, Subtitle = campaign.Subtitle,
                    Tags = campaign.Tags, Text = campaign.Text, Theme = campaign.Theme, ThemeId = campaign.ThemeId,
                    TotalMoneyAmount = campaign.TotalMoneyAmount, VideoURL = campaign.VideoURL
                };
                model.CampaignViewModels.ToList().Add(campaignViewModel);
            }*/
            return View(model);
        }
    }
}
