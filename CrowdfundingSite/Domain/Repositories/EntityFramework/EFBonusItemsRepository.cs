using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFBonusItemsRepository : IBonusItemsRepository
    {
        private readonly DbContext context;
        public EFBonusItemsRepository(DbContext context) => this.context = context;

        public IQueryable<Bonus> GetAllBonuses(Guid campaignId)
        {
            return (IQueryable<Bonus>)context.Bonuses.FirstOrDefault(x => x.CampaignId == campaignId);
        }
        public Bonus GetBonusById(Guid id)
        {
            return context.Bonuses.FirstOrDefault(x => x.Id == id);
        }
        public void SaveBonus(Bonus entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteBonus(Guid id)
        {
            context.Bonuses.Remove(new Bonus() { Id = id });
            context.SaveChanges();
        }
    }
}
