using CrowdfundingSite.Domain.Images;
using CrowdfundingSite.Service.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class Campaign : EntityBase
    {
        public Campaign() { TotalMoneyAmount = 0; AverageRating = 0; }

        public virtual CrowdUser Creator { get; set; }
        [Display(Name = "Создатель кампании")]
        [Required(ErrorMessage = "Выберите создателя кампании")]
        public string CreatorId { get; set; }

        [Required(ErrorMessage = "Введите название кампании")]
        [Display(Name = "Название кампании")]
        public override string Title { get; set; }

        public virtual Subject Theme { get; set; }
        [Display(Name = "Тематика кампании")]
        [Required(ErrorMessage = "Выберите тематику кампании")]
        public Guid ThemeId { get; set; }

        [Required(ErrorMessage = "Введите краткое описание")]
        [Display(Name = "Краткое описание")]
        public override string Subtitle { get; set; }

        //[Required(ErrorMessage = "Загрузите обложку кампании")]
        [Display(Name = "Обложка кампании")]
        public string CoverPath { get; set; }

        [Display(Name = "Галерея изображений")]
        public ICollection<CampaignImage> Images { get; set; }

        [Required]
        [Display(Name = "Целевая сумма денег")]
        [Range(typeof(decimal), "5,0", "10000000,6", ErrorMessage = "Наименьшая цена - 5 рублей, в качестве разделителя дробной и целой части используется запятая")]
        public virtual decimal RequiredMoneyAmount { get; set; }

        //[Required(ErrorMessage = "Введите хотя бы один тэг")]
        [Display(Name = "Тэги кампании")]
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        [Display(Name = "Бонусы кампании")]
        public ICollection<Bonus> Bonuses { get; set; } = new List<Bonus>();

        [Display(Name = "Новости кампании")]
        public ICollection<News> News { get; set; } = new List<News>();

        [Display(Name = "Общая сумма денег")]
        public decimal TotalMoneyAmount { get; set; }

        [Display(Name = "Средний рейтинг")]
        public double AverageRating { get; set; }

        [Display(Name = "Комментарии")]
        public ICollection<Comment> Comments { get; set; }

        [Required(ErrorMessage = "Введите дату окончания")]
        [DataType(DataType.Date)]
        [EndDate(ErrorMessage = "Дата окончания не может быть прошедшей или больше чем на три года вперёд")]
        public virtual DateTime EndDate { get; set; }
    }
}
