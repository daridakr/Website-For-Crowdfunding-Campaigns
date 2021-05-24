using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    class EFSubjectsRepository : ISubjectsRepository
    {
        private readonly DbContext context;
        public EFSubjectsRepository(DbContext context) => this.context = context;

        public IQueryable<Subject> GetAllSubjects()
        {
            return context.Subjects;
        }
        public Subject GetSubjectById(Guid id)
        {
            return context.Subjects.FirstOrDefault(x => x.Id == id);
        }
        public void SaveSubject(Subject entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteSubject(Guid id)
        {
            context.Subjects.Remove(new Subject() { Id = id });
            context.SaveChanges();
        }
    }
}
