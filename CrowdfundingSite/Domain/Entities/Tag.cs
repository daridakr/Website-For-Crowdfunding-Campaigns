using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Entities
{
    public class Tag
    {
        public Tag() => DateAdded = DateTime.UtcNow;

        [Key]
        [Required]
        public Guid Id { get; set; }

        public virtual string Title { get; set; }

        public ICollection<Campaign> Campaigns { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
    }
}
