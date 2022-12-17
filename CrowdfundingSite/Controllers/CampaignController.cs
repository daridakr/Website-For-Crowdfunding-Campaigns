using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using CrowdfundingSite.Domain.Repositories.EntityFramework;
using CrowdfundingSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CrowdfundingSite.Controllers
{
    public class CampaignController : Controller
    {

        private readonly IСampaignItemsRepository campaignRepository;
        private readonly ISubjectsRepository subjectsRepository;
        private readonly IUsersRepository usersRepository;
        private readonly ICampaignImagesRepository campaignImagesRepository;
        private readonly IRatingRepository ratingRepository;
        private readonly ICommentsRepository commentsRepository;
        private readonly INewsRepository newsRepository;
        private readonly IBonusItemsRepository bonusRepository;
        private readonly DataManager dataManager;
        private readonly UserManager<CrowdUser> _userManager;

        public CampaignController(IСampaignItemsRepository сampaignItemsRepository,
            ISubjectsRepository subjectsRepository, IUsersRepository usersRepository,
            ICampaignImagesRepository campaignImagesRepository, INewsRepository newsRepository,
            IRatingRepository ratingRepository, ICommentsRepository commentsRepository,
            IBonusItemsRepository bonusRepository,
            DataManager dataManager, UserManager<CrowdUser> userManager)
        {
            campaignRepository = сampaignItemsRepository;
            this.subjectsRepository = subjectsRepository;
            this.usersRepository = usersRepository;
            this.campaignImagesRepository = campaignImagesRepository;
            this.dataManager = dataManager;
            this.ratingRepository = ratingRepository;
            this.commentsRepository = commentsRepository;
            this.newsRepository = newsRepository;
            this.bonusRepository = bonusRepository;
            _userManager = userManager;
        }

        public IActionResult GetAllCampaignes()
        {
            var model = new EntitiesViewModel();
            model.Campaigns = dataManager.СampaignItems.GetAllСampaigns();
            model.Users = dataManager.Users.GetAllUsers();
            model.Subjects = dataManager.Subjects.GetAllSubjects();
            model.Tags = dataManager.Tags.GetAllTags();
            return View(model);
            /*
             var data = campaignRepository.GetAllСampaigns();
            return View(data);
             */

        }

        public ViewResult GetCampaign(Guid id)
        {
            ViewBag.CurId = id;

            CampaignViewModel data = new CampaignViewModel();

            data.Campaign = campaignRepository.GetСampaignById(id);

            var sub = subjectsRepository.GetSubjectById(data.Campaign.ThemeId);
            data.Campaign.Theme = sub;

            var author = usersRepository.GetUserById(Guid.Parse(data.Campaign.CreatorId));
            data.Campaign.Creator = author;

            var images = campaignImagesRepository.GetAllCampaignImages(data.Campaign.Id);
            data.Campaign.Images = images.ToList();

            var ratings = ratingRepository.GetAllCampaignRatings(data.Campaign.Id);
            data.Campaign.Ratings = ratings.ToList();

            var comments = commentsRepository.GetAllComments(data.Campaign.Id);
            data.Campaign.Comments = comments.ToList();

            var news = newsRepository.GetAllNews(data.Campaign.Id);
            data.Campaign.News = news.ToList();

            var bonuses = bonusRepository.GetAllBonuses(data.Campaign.Id);
            data.Campaign.Bonuses = bonuses.ToList();

            if (User.Identity.IsAuthenticated) data.User = usersRepository.GetUserById(Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));


            data.Comment = new Comment();

            return View(data);
        }

        public ViewResult SearchCampaignes(string name)
        {
            var model = new EntitiesViewModel();
            model.Campaigns = campaignRepository.SearchCampaigns(name);
            model.Users = dataManager.Users.GetAllUsers();
            model.Subjects = dataManager.Subjects.GetAllSubjects();
            model.Tags = dataManager.Tags.GetAllTags();
            return View(model);
        }


        public ActionResult Rating(Guid campaignId, int starNum)
        {
            if (User.IsInRole("user"))
            {
                var campaign = campaignRepository.GetСampaignById(campaignId);
                // создание записи и сохранение ее в БД
                Rating rating = new Rating();
                rating.CampaignId = campaignId;
                rating.Stars = starNum;
                rating.CrowdUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                dataManager.Rating.SaveCampaignRating(rating);
                // берем все поставленные кампании звездочки
                var ratings = dataManager.Rating.GetAllCampaignStars(campaignId);
                // пересчитываем рейтинг
                campaign.AverageRating = calculateRating(ratings.ToList());
                // сохраняем изменения в БД
                dataManager.СampaignItems.SaveСampaign(campaign);
                return RedirectToAction("GetCampaign", new { id = campaignId });
            }
            return Redirect("/account/login");
        }

        private int calculateRating(List<int> stars)
        {
            double average = stars.Average();
            var integralPart = Math.Truncate(average); // Целая часть
            int rating = 0;
            switch (integralPart)
            {
                case 1: rating = 20; break;
                case 2: rating = 40; break;
                case 3: rating = 60; break;
                case 4: rating = 80; break;
                case 5: rating = 100; break;
            }
            if (!(Convert.ToInt32(average) == Convert.ToDouble(average)))
            {
                average = Math.Round(average, 2);
                var fractionalPart = (average - integralPart) * 10; // Дробная часть
                int i = 0;
                while (i < fractionalPart)
                {
                    rating += 2;
                    i++;
                }
            }
            return rating;
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CampaignViewModel model)
        {
            var actionResult = await CreateComment(model);

            if (actionResult.Result is null)
                return RedirectToAction("GetCampaign", new { id = model.Campaign.Id });

            return actionResult.Result;
        }

        public async Task<ActionResult<Comment>> CreateComment(CampaignViewModel model)
        {
            var campaign = campaignRepository.GetСampaignById(model.Campaign.Id);
            var user = usersRepository.GetUserById(Guid.Parse(model.User.Id));
            var comment = model.Comment;
            comment.User = user;
            comment.Campaign = campaign;
            comment.DateAdded = DateTime.Now;
            comment.Likes = 0;
            return await commentsRepository.Add(comment);
        }
    }
}
