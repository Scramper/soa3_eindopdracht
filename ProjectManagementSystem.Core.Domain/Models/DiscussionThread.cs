
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class DiscussionThread
    {
        public int Id { get; set; }
        public int BacklogItemId { get; set; }
        public string Topic { get; set; }
        public List<DiscussionPost> Posts { get; set; } = new List<DiscussionPost>();
    }
}
