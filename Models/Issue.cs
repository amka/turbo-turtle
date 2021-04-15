using System;

namespace TurboTurtle.Models
{
    public class Issue
    {
        public  string Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Modified { get; set; } = DateTime.UtcNow;
        
        public string AccountId { get; set; }
        public Account Author { get; set; }
        
        public string IssueListId { get; set; }
        public IssueList IssueList { get; set; }
    }
}