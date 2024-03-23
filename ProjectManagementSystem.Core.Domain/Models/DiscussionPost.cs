
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class DiscussionPost
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }

        public void EditMessage(string newMessage)
        {
            Message = newMessage;
            Timestamp = DateTime.UtcNow; // Update timestamp when the post is edited
        }
    }
}
