using CrowdfundingSite.Domain;
using CrowdfundingSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        // главная
        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            // многократное обращение к бд, сделать асинхронным?
            // и нужно ли модель ВСЕХ сущностей? на главной только список кампаний?
            var model = new EntitiesViewModel();
            model.Campaigns = dataManager.СampaignItems.GetAllСampaigns();
            model.Users = dataManager.Users.GetAllUsers();
            model.Subjects = dataManager.Subjects.GetAllSubjects();
            model.Tags = dataManager.Tags.GetAllTags();
            return View(model);
        }

        [Authorize(Roles = "admin, user")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Main()
        {
            return View(new EntitiesViewModel());
        }
    }
}
