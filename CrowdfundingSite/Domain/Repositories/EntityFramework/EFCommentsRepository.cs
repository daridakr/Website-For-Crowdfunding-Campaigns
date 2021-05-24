using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Domain.Repositories.EntityFramework
{
    public class EFCommentsRepository : ICommentsRepository
    {
        private readonly DbContext context;
        public EFCommentsRepository(DbContext context) => this.context = context;

        public IQueryable<Comment> GetAllComments(Guid campaignId)
        {
            return (IQueryable<Comment>)context.Comments.FirstOrDefault(x => x.CampaignId == campaignId);
        }
        public Comment GetCommentById(Guid id)
        {
            return context.Comments.FirstOrDefault(x => x.Id == id);
        }
        public void DeleteComment(Guid id)
        {
            context.Comments.Remove(new Comment() { Id = id });
            context.SaveChanges();
        }
    }
}
