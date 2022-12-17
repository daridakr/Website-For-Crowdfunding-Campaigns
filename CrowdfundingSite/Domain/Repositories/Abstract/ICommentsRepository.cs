using CrowdfundingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.Abstract
{
    public interface ICommentsRepository
    {
        IEnumerable<Comment> GetAllComments(Guid campaignId);
        Comment GetComment(Guid commentId);
        void DeleteComment(Guid id);
        Task<Comment> Add(Comment comment);
    }
}
