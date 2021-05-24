using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFUsersRepository : IUsersRepository
    {
        private readonly DbContext context;
        public EFUsersRepository(DbContext context) => this.context = context;

        public IQueryable<CrowdUser> GetAllUsers()
        {
            return context.Users;
        }
        public CrowdUser GetUserById(Guid id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id.ToString());
        }
        public void SaveUserInformation(CrowdUser entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteUser(Guid id)
        {
            context.Users.Remove(new CrowdUser() { Id = id.ToString() });
            context.SaveChanges();
        }
        public void BlockUser(Guid id)
        {

        }
        public void AssignAdmin(Guid id)
        {
            context.UserRoles.Add(new IdentityUserRole<string>() { UserId = id.ToString(), RoleId = "5207a125-9669-4216-8b8f-9b7bad955cd7"});
        }
    }
}
