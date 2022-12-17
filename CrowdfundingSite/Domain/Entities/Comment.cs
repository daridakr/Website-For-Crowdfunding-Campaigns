using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class Comment : EntityBase
    {
        [Required]
        public Guid CampaignId { get; set; }
        [Required]
        public Campaign Campaign { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public CrowdUser User { get; set; }

        [Required(ErrorMessage = "Введите текст комментария")]
        [Display(Name = "Текст комментария")]
        public override string Text { get; set; }

        public int Likes { get; set; }

    }
}
