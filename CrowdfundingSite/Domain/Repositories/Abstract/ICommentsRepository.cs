using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface ICommentsRepository
    {
        IQueryable<Comment> GetAllComments(Guid campaignId);
        Comment GetCommentById(Guid id);
        void DeleteComment(Guid id);
    }
}
