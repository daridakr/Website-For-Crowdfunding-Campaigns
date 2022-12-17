using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFСampaignItemsRepository : IСampaignItemsRepository 
    {
        private readonly DbContext context = null;

        public EFСampaignItemsRepository(DbContext context) => this.context = context;

        public IQueryable<Campaign> GetAllСampaigns()
        {
            return context.Campaigns;
        }
        public Campaign GetСampaignById(Guid id)
        {
            return context.Campaigns.FirstOrDefault(x => x.Id == id);
        }
        public int GetCountOfCampaigns()
        {
            return context.Campaigns.Count();
        }
        public void SaveСampaign(Campaign entity)
        {
            // если идентификатор равен заданному по умолчанию, значит что новая запись создана, т.к. идентификатора для нее еще нет
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            // помечаем его как новый объект, ef его добавит вю бд, иначе помечаем его как изменен
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Guid AddNewCampaign(Campaign model)
        {
            var newCampaign = new Campaign()
            {
                TotalMoneyAmount = model.TotalMoneyAmount,
                AverageRating = model.AverageRating,
                CoverPath = model.CoverPath,
                Creator = model.Creator,
                CreatorId = model.CreatorId,
                DateAdded = model.DateAdded,
                EndDate = model.EndDate,
                Id = model.Id,
                Images = model.Images,
                RequiredMoneyAmount = model.RequiredMoneyAmount,
                Subtitle = model.Subtitle,
                Theme = model.Theme,
                Text = model.Text,
                Title = model.Title,
                VideoURL = model.VideoURL,
                ThemeId = model.ThemeId
            };
            context.Campaigns.Add(newCampaign);
            context.SaveChanges();
            return newCampaign.Id;
        }

        public void DeleteСampaign(Guid id)
        {
            context.Campaigns.Remove(new Campaign() { Id = id });
            context.SaveChanges();
        }

        public List<Campaign> SearchCampaigns(string name)
        {
            return context.Campaigns.Where(camp => camp.Title.Contains(name) || camp.Theme.Title.Contains(name)).ToList();
        }
    }
}
