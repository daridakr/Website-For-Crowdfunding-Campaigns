using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFNewsRepository : INewsRepository
    {
        private readonly DbContext context;
        public EFNewsRepository(DbContext context) => this.context = context;

        public IQueryable<News> GetAllNews(Guid campaignId)
        {
            return (IQueryable<News>)context.News.FirstOrDefault(x => x.CampaignId == campaignId);
        }
        public News GetNewById(Guid id)
        {
            return context.News.FirstOrDefault(x => x.Id == id);
        }
        public void SaveNew(News entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteNew(Guid id)
        {
            context.News.Remove(new News() { Id = id });
            context.SaveChanges();
        }
    }
}
