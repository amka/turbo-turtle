using System.Collections.Generic;
using System.Linq;
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
            return await query.ToListAsync();
        }

        public async Task CreateIssueAsync(Issue model)
        {
            _dbContext.Issues.Add(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}