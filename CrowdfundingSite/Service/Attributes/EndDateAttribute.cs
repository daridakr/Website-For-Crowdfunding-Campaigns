using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Service.Attributes
{
    public class EndDateAttribute : RangeAttribute
    {
        public EndDateAttribute()
    : base(typeof(DateTime),
            DateTime.Now.ToShortDateString(),
            DateTime.Now.AddYears(3).ToShortDateString())
        { }
    }
}
