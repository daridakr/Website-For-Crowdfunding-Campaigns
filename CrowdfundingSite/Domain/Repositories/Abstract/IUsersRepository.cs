using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface IUsersRepository
    {
        IQueryable<CrowdUser> GetAllUsers();
        CrowdUser GetUserById(Guid id);
        void SaveUserInformation(CrowdUser entity);
        void DeleteUser(Guid id);
        void BlockUser(Guid id);
        void AssignAdmin(Guid id);
    }
}
