using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class Bonus : EntityBase
    {
        [Required]
        public Guid CampaignId { get; set; }
        public Campaign Campaign { get; set; }

        [Required(ErrorMessage = "Введите название бонуса (например, Футболка с логотипом)")]
        [Display(Name = "Название бонуса")]
        public override string Title { get; set; }

        [Display(Name = "Описание бонуса")]
        public override string Text { get; set; }

        [Required(ErrorMessage = "Введите сумму")]
        [Display(Name = "Сумма перевода")]
        public virtual double TransferAmount { get; set; }

        [Display(Name = "Поддержавшие пользователи")]
        public ICollection<CrowdUser> SupportingUsers { get; set; } 
    }
}
