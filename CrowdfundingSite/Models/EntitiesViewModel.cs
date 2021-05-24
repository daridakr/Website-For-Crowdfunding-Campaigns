using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Models
{
    public class EntitiesViewModel
    {
        public IEnumerable<Campaign> Campaigns { get; set; }
        public IEnumerable<CrowdUser> Users { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Subject Subject { get; set; }
        public Tag Tag { get; set; }

    }
}
