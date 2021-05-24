using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Service.Attributes
{
    public class BirthDateAttribute : RangeAttribute
    {
        public BirthDateAttribute()
    : base(typeof(DateTime),
            DateTime.Now.AddYears(-110).ToShortDateString(),
            DateTime.Now.AddYears(-18).ToShortDateString())
        { }
    }
}
