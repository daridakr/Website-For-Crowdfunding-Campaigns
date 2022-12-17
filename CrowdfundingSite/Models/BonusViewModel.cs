using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Models
{
    public class BonusViewModel
    {
        public Campaign Campaign { get; set; }
        public Bonus Bonus { get; set; }
    }
}
