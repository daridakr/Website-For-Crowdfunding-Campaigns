using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Models
{
    public class ChangePasswordModel
    {
        [Required, DataType(DataType.Password), Display(Name="Текущий пароль")]
        public string CurrentPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Подтвердите новый пароль")]
        [Compare("NewPassword", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmNewPassword { get; set; }
    }
}
