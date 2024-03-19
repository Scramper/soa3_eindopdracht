
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class DiscussionPost
    {
        public int Id { get; set; }
        public string Author { get; set; } // Consider using User class
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
