using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class News : EntityBase
    {
        [Required]
        public Guid CampaignId { get; set; }
        [Required]
        public Campaign Campaign { get; set; }

        [Required(ErrorMessage = "Введите заголовок")]
        [Display(Name = "Заголовок новости")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "Введите текст")]
        [Display(Name = "Текст новости")]
        public override string Text { get; set; }

        [Display(Name = "Картинка новости")]
        public virtual string ImagePath { get; set; }
    }
}