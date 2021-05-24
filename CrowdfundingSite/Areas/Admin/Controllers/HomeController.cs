using CrowdfundingSite.Domain;
using CrowdfundingSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            return View(model);
        }
    }
}
