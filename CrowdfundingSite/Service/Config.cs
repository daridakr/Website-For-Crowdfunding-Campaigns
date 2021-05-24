using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string SiteTitle { get; set; }
        public static string Phone { get; set; }
        public static string PhoneShort { get; set; }
        public static string Email { get; set; }
        public static string NormalizedEmail { get; set; }
        public static string AdminRoleName { get; set; }
        public static string AdminNormalizeRoleName { get; set; }
        public static string AdminRoleId { get; set; }
        public static string AdminId { get; set; }
        public static string UserRoleName { get; set; }
        public static string UserNormalizeRoleName { get; set; }
        public static string UserRoleId { get; set; }
    }
}
