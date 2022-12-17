using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Models
{
    public class PaymentViewModel
    {
        [Required(ErrorMessage = "Введите номер карты")]
        [Display(Name = "Номер карты")]
        public string Card { get; set; }

        [Required(ErrorMessage = "Введите сумму")]
        [Display(Name = "Сумма (руб.)")]
        public decimal Sum { get; set; }

        [Required(ErrorMessage = "Заполните поле месяц/год")]
        [Display(Name = "Месяц/год")]
        public string MounthYear { get; set; }

        [Required(ErrorMessage = "Заполните поле CVC/CVV код")]
        [Display(Name = "CVC/CVV код")]
        public string CVC { get; set; }

        [Required]
        public Guid CampaignId { get; set; }

    }
}
