using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFTagsRepository : ITagsRepository
    {
        private readonly DbContext context;
        public EFTagsRepository(DbContext context) => this.context = context;

        public IQueryable<Tag> GetAllTags()
        {
            return context.Tags;
        }
        public Tag GetTagById(Guid id)
        {
            return context.Tags.FirstOrDefault(x => x.Id == id);
        }
        public void SaveTag(Tag entity)
        {
            if (entity.Id == default) context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteTag(Guid id)
        {
            context.Tags.Remove(new Tag() { Id = id });
            context.SaveChanges();
        }
    }
}
