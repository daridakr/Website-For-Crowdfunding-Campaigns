using CrowdfundingSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain
{
    // здесь централизовано содержится управление репозиторием
    public class DataManager
    {
        public IСampaignItemsRepository СampaignItems { get; set; }
        public IUsersRepository Users { get; set; }
        public INewsRepository News { get; set; }
        public ICommentsRepository Comments { get; set; }
        public IBonusItemsRepository BonusItems { get; set; }
        public ITagsRepository Tags { get; set; }
        public ISubjectsRepository Subjects { get; set; }
        public ICampaignImagesRepository CampaignImages { get; set; }
        public IRatingRepository Rating { get; set; }


        public DataManager(IСampaignItemsRepository campaignItemsRepository,
            IUsersRepository usersRepository,
            INewsRepository newsRepository,
            ICommentsRepository commentsRepository,
            IBonusItemsRepository bonusItemsRepository,
            ISubjectsRepository subjectsRepository,
            ITagsRepository tagsRepository,
            ICampaignImagesRepository campaignImages,
            IRatingRepository rating )
        {
            СampaignItems = campaignItemsRepository;
            Users = usersRepository;
            News = newsRepository;
            Comments = commentsRepository;
            BonusItems = bonusItemsRepository;
            Tags = tagsRepository;
            Subjects = subjectsRepository;
            CampaignImages = campaignImages;
            Rating = rating;
        }
    }
}
