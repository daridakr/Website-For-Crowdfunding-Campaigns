using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface ISubjectsRepository
    {
        IQueryable<Subject> GetAllSubjects();
        Subject GetSubjectById(Guid id);
        void SaveSubject(Subject entity);
        void DeleteSubject(Guid id);
    }
}
