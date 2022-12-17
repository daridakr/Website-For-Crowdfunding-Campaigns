using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface IBonusItemsRepository
    {
        IEnumerable<Bonus> GetAllBonuses(Guid campaignId);
        Bonus GetBonusById(Guid id);
        Task<Bonus> Add(Bonus comment);

        void DeleteBonus(Guid id);
    }
}
