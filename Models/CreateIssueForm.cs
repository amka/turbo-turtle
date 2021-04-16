using System.ComponentModel.DataAnnotations;

namespace TurboTurtle.Models
{
    public class CreateIssueForm
    {
        [Required]
        public string Title { get; set; }
        
        public bool Done { get; set; }
    }
}