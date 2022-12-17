using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Controllers
{
    public class PaymentController : Controller
    {
        private readonly DataManager dataManager;

        public PaymentController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Donate(Guid id)
        {
            if (User.IsInRole("user"))
            {
                ViewBag.CampId = id;
                return View();
            }
            Response.Redirect("/account/login");
            return View();
        }

        [HttpPost]
        public ActionResult Donate(PaymentViewModel model, Guid id)
        {
            if (ModelState.IsValid)
            {
                Campaign camp = dataManager.СampaignItems.GetСampaignById(id);
                camp.TotalMoneyAmount += model.Sum;
                dataManager.СampaignItems.SaveСampaign(camp);
                return RedirectToAction("GetAllCampaignes", "Campaign");
            }
            else
            {
                ViewBag.CampId = id;
            }
            return View(model);
        }
    }
}
