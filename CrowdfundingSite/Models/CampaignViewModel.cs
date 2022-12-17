using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Models
{
    public class CampaignViewModel
    {
        public Campaign Campaign { get; set; }
        public Comment Comment { get; set; }
        public CrowdUser User { get; set; }
    }
}
