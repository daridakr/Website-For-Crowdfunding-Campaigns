using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Comment> GetAllComments(Guid campaignId)
        {
            IEnumerable<Comment> comments = from i in context.Comments.AsQueryable()
                                          where i.CampaignId == campaignId
                                          select i;
            return comments;
        }
        public Comment GetComment(Guid commentId)
        {
            return context.Comments
                .Include(comment => comment.User)
                .Include(comment => comment.Campaign)
                .FirstOrDefault(comment => comment.Id == commentId);
        }

        public void DeleteComment(Guid id)
        {
            context.Comments.Remove(new Comment() { Id = id });
            context.SaveChanges();
        }

        //public void SaveComment(Comment comment)
        //{
        //    if (comment.Id == default) context.Entry(comment).State = EntityState.Added;
        //    else context.Entry(comment).State = EntityState.Modified;
        //    context.SaveChanges();
        //}

        public async Task<Comment> Add(Comment comment)
        {
            context.Add(comment);
            await context.SaveChangesAsync();
            return comment;
        }
    }
}
