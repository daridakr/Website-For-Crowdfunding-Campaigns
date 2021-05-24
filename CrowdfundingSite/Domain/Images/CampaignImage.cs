using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Images
{
    public class CampaignImage
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public virtual Campaign Campaign { get; set; }

        [Required]
        public Guid CampaignId { get; set; }

        [Required]
        public string ImagePath { get; set; }
    }
}
