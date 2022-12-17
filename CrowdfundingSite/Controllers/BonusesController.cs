using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using CrowdfundingSite.Models;
using CrowdfundingSite.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CrowdfundingSite.Controllers
{
    public class BonusesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IBonusItemsRepository bonusRepository; 

       public BonusesController(DataManager dataManager, IBonusItemsRepository bonusRepository)
        {
            this.dataManager = dataManager;
            this.bonusRepository = bonusRepository;
        }

        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public IActionResult Add(Guid id)
        {
            BonusViewModel model = new BonusViewModel();
            model.Campaign = dataManager.СampaignItems.GetСampaignById(id);
            model.Bonus = new Bonus();
            //SelectList campaignesList = new SelectList(dataManager.СampaignItems.GetAllСampaigns().Where(camp => camp.CreatorId == userId), "Id", "Title");
            //ViewBag.Campaigns = campaignesList;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BonusViewModel model)
        {
            var actionResult = await CreateBonus(model);

            if (actionResult.Result is null)
                return Redirect("/Home/Index/");

            return actionResult.Result;
        }

        public async Task<ActionResult<Bonus>> CreateBonus(BonusViewModel model)
        {
            var campaign = dataManager.СampaignItems.GetСampaignById(model.Campaign.Id);
            var bonus = model.Bonus;
            bonus.Campaign = campaign;
            bonus.DateAdded = DateTime.Now;
            return await bonusRepository.Add(bonus);
        }



        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.BonusItems.DeleteBonus(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
