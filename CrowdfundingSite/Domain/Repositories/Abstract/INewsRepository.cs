using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface INewsRepository
    {
        IQueryable<News> GetAllNews(Guid campaignId);
        News GetNewById(Guid id);
        void SaveNew(News entity);
        void DeleteNew(Guid id);
    }
}
