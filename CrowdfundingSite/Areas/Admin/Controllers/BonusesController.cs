using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BonusesController : Controller
    {
        private readonly DataManager dataManager;

        public BonusesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var bonus = new Bonus();
            return View(bonus);
        }

        //[HttpPost]
        //public ActionResult Create(Bonus bonus, Guid campaignId)
        //{
        //    bonus.CampaignId = campaignId;
        //    dataManager.BonusItems.SaveBonus(bonus);
        //    return View();
        //}
    }
}
