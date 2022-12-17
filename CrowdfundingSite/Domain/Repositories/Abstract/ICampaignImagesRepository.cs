using CrowdfundingSite.Domain.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface ICampaignImagesRepository
    {
        IEnumerable<CampaignImage> GetAllCampaignImages(Guid campaignId);
        CampaignImage GetCampaignImageById(Guid id);
        void SaveCampaignImage(CampaignImage image);
        void DeleteCampaignImage(Guid id);
    }
}
