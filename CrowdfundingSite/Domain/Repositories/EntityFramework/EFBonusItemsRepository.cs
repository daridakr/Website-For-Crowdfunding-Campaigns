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

        public IEnumerable<Bonus> GetAllBonuses(Guid campaignId)
        {
            IEnumerable<Bonus> bonuses = from i in context.Bonuses.AsQueryable()
                                     where i.CampaignId == campaignId
                                     select i;
            return bonuses;
        }
        public Bonus GetBonusById(Guid id)
        {
            return context.Bonuses.FirstOrDefault(x => x.Id == id);
        }
        public async Task<Bonus> Add(Bonus bonus)
        {
            context.Add(bonus);
            await context.SaveChangesAsync();
            return bonus;
        }
        public void DeleteBonus(Guid id)
        {
            context.Bonuses.Remove(new Bonus() { Id = id });
            context.SaveChanges();
        }
    }
}
