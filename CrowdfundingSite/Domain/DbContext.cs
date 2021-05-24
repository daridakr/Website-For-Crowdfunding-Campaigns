using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Images;
using CrowdfundingSite.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain
{
    public class DbContext : IdentityDbContext<CrowdUser>
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbContext() : base() { }

        public static DbContext Create()
        {
            return new DbContext();
        }

        // проецирование моделей на базу данных
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CampaignImage> CampaignImages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Campaign>().HasOne(c => c.Creator).WithMany(u => u.Campaignes).HasForeignKey(u => u.CreatorId);
            builder.Entity<Campaign>().HasOne(c => c.Theme).WithMany(u => u.Campaigns).HasForeignKey(u => u.ThemeId);
            builder.Entity<Campaign>().HasMany(c => c.Images).WithOne(p => p.Campaign).HasForeignKey(u=>u.CampaignId);
            builder.Entity<Campaign>().HasMany(c => c.Tags).WithMany(p => p.Campaigns);
            builder.Entity<Campaign>().HasMany(c => c.Bonuses).WithOne(p => p.Campaign).HasForeignKey(u=>u.CampaignId);
            builder.Entity<Campaign>().HasMany(c => c.News).WithOne(p => p.Campaign).HasForeignKey(u => u.CampaignId);
            builder.Entity<Campaign>().HasMany(c => c.Comments).WithOne(p => p.Campaign).HasForeignKey(u => u.CampaignId);
            builder.Entity<CrowdUser>().HasMany(c => c.Comments).WithOne(p => p.User).HasForeignKey(u => u.UserId);
            builder.Entity<Bonus>().HasMany(c => c.SupportingUsers).WithMany(p => p.PaidBonuses);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Config.AdminRoleId,
                Name = Config.AdminRoleName,
                NormalizedName = Config.AdminNormalizeRoleName
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Config.UserRoleId,
                Name = Config.UserRoleName,
                NormalizedName = Config.UserNormalizeRoleName
            });

            builder.Entity<CrowdUser>().HasData(new CrowdUser
            {
                Id = Config.AdminId,
                UserName = Config.AdminRoleName,
                UserSurname = "",
                NormalizedUserName = Config.AdminNormalizeRoleName,
                Email = Config.Email,
                NormalizedEmail = Config.NormalizedEmail,
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<CrowdUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            // связываем админа с его ролью
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = Config.AdminRoleId,
                UserId = Config.AdminId
            });
        }
    }
}
