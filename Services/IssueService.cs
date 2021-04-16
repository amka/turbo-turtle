using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TurboTurtle.Data;
using TurboTurtle.Models;

namespace TurboTurtle.Services
{
    public class IssueService
    {
        private ApplicationDbContext _dbContext;

        public IssueService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Issue>> GetIssuesAsync()
        {
            IQueryable<Issue> query = _dbContext.Issues;

            // Todo: make it searchable
            query = query.OrderByDescending(i => i.Created);
            return await query.ToListAsync();
        }

        public async Task CreateIssueAsync(Issue model)
        {
            _dbContext.Issues.Add(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateIssueAsync(Guid issueId, Issue issue,
            CancellationToken ct = default(CancellationToken))
        {
            var entity = await _dbContext.Issues.FirstOrDefaultAsync(i => i.Id == issueId, ct);

            entity.Done = issue.Done;
            if (issue.Title != null) entity.Title = issue.Title;
            // if (issue.Description != null) entity.Description = issue.Description;
            _dbContext.Update(entity);

            var result = await _dbContext.SaveChangesAsync(ct);

            return result >= 1;
        }

        public async Task<bool> RemoveIssueAsync(Guid issueId,
            CancellationToken ct = default(CancellationToken))
        {
            var entity = await _dbContext.Issues.FirstOrDefaultAsync(x => x.Id == issueId, ct);
            if (entity == null) return false;

            _dbContext.Issues.Remove(entity);

            var result = await _dbContext.SaveChangesAsync(ct);

            return result >= 1;
        }
    }
}