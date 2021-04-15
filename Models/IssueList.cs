using System;
using System.Collections.Generic;

namespace TurboTurtle.Models
{
    public class IssueList
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Modified { get; set; } = DateTime.UtcNow;

        public Account Owner { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}