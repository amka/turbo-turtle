using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TurboTurtle.Models
{
    public class Account : IdentityUser
    {
        public IEnumerable<IssueList> IssueLists { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}