using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface IRatingRepository
    {
        IEnumerable<int> GetAllCampaignStars(Guid campaignId);
        IEnumerable<Rating> GetAllCampaignRatings(Guid campaignId);
        Rating GetCampaignRatingById(Guid id);
        void SaveCampaignRating(Rating rating);
        void DeleteCampaignRating(Guid id);
    }
}
