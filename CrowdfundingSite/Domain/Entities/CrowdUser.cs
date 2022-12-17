using CrowdfundingSite.Service.Attributes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class CrowdUser : IdentityUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }

        [Required(ErrorMessage = "Введите своё имя")]
        [Display(Name = "Имя пользователя")]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "Введите свою фамилию")]
        [Display(Name = "Фамилия пользователя")]
        public string UserSurname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        [BirthDate(ErrorMessage = "Вам должно быть 18 лет")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Аватарка")]
        public virtual string AvatarPath { get; set; }

        [Display(Name = "Страна проживания")]
        public virtual string Country { get; set; }

        [Display(Name = "Город проживания")]
        public virtual string City { get; set; }

        [Display(Name = "Информация о пользователе")]
        public virtual string TextInformation { get; set; }

        [Display(Name = "Кампании пользователя")]
        public ICollection<Campaign> Campaignes { get; set; } = new List<Campaign>();

        [Display(Name = "Оплаченные бонусы")]
        public ICollection<Bonus> PaidBonuses { get; set; } = new List<Bonus>();

        [Display(Name = "Комментарии")]
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<Rating> Ratings { get; set; }
    }
}
