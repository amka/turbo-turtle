using System;

namespace TurboTurtle.Models
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Modified { get; set; } = DateTime.UtcNow;
        
        public Account Author { get; set; }
        
        public IssueList IssueList { get; set; }
    }
}