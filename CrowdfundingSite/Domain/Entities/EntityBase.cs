using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название (заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        [Display(Name = "Видео")]
        public virtual string VideoURL { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

        // metatags
        [Display(Name = "SEO метатег Title")]
        public virtual double MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public virtual double MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public virtual double MetaKeywords { get; set; }

    }
}


/*
	Список "бонусов";

	Тэги (вводится несколько тэгов, необходимо автодополнение - когда пользователь начинает вводить тэг, выпадает список с вариантами слов, которые уже вводились ранее на сайте);
	Галерея изображений (хранение в облаке, загружаются драг-н-дропом);
 */