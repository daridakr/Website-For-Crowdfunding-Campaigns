using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface IBonusItemsRepository
    {
        IQueryable<Bonus> GetAllBonuses(Guid campaignId);
        Bonus GetBonusById(Guid id);
        void SaveBonus(Bonus entity);
        void DeleteBonus(Guid id);
    }
}
