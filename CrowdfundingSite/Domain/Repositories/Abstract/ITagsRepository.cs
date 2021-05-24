using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface ITagsRepository
    {
        IQueryable<Tag> GetAllTags();
        Tag GetTagById(Guid id);
        void SaveTag(Tag entity);
        void DeleteTag(Guid id);
    }
}
