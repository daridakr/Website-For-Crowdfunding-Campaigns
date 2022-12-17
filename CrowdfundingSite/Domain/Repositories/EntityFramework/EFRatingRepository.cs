using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFRatingRepository : IRatingRepository
    {
        private readonly DbContext context;
        public EFRatingRepository(DbContext context) => this.context = context;

        public void DeleteCampaignRating(Guid id)
        {
            context.Ratings.Remove(new Rating() { Id = id });
            context.SaveChanges();
        }

        public IEnumerable<int> GetAllCampaignStars(Guid campaignId)
        {
            IEnumerable<int> ratings = from i in context.Ratings.AsQueryable()
                                          where i.CampaignId == campaignId
                                          select i.Stars;
            return ratings;
        }

        public IEnumerable<Rating> GetAllCampaignRatings(Guid campaignId)
        {
            IEnumerable<Rating> ratings = from i in context.Ratings.AsQueryable()
                                         where i.CampaignId == campaignId
                                         select i;
            return ratings;
        }

        public Rating GetCampaignRatingById(Guid id)
        {
            return context.Ratings.FirstOrDefault(x => x.Id == id);
        }

        public void SaveCampaignRating(Rating rating)
        {
            if (rating.Id == default) context.Entry(rating).State = EntityState.Added;
            else context.Entry(rating).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
