using CrowdfundingSite.Domain.Images;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFCampaignImagesRepository : ICampaignImagesRepository
    {
        private readonly DbContext context;
        public EFCampaignImagesRepository(DbContext context) => this.context = context;

        public IEnumerable<CampaignImage> GetAllCampaignImages(Guid campaignId)
        {
            IEnumerable<CampaignImage> images = from i in context.CampaignImages.AsQueryable()
                                                where i.CampaignId==campaignId
                                                select i;
            return images;
            //return (ICollection<CampaignImage>)context.CampaignImages.FirstOrDefault(x => x.CampaignId == campaignId);
        }
        public CampaignImage GetCampaignImageById(Guid id)
        {
            return context.CampaignImages.FirstOrDefault(x => x.Id == id);
        }
        public void SaveCampaignImage(CampaignImage entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCampaignImage(Guid id)
        {
            context.CampaignImages.Remove(new CampaignImage() { Id = id });
            context.SaveChanges();
        }
    }
}
