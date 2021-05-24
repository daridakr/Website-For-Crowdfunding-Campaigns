using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface IСampaignItemsRepository
    {
        IQueryable<Campaign> GetAllСampaigns();
        Campaign GetСampaignById(Guid id);
        void SaveСampaign(Campaign entity);
        void DeleteСampaign(Guid id);
        int GetCountOfCampaigns();
    }
}
