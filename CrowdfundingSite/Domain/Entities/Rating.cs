using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class Rating
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public virtual Campaign Campaign { get; set; }

        [Required]
        public Guid CampaignId { get; set; }

        [Required]
        public virtual CrowdUser CrowdUser { get; set; }

        [Required]
        public string CrowdUserId { get; set; }

        [Required]
        public int Stars { get; set; }
    }
}
