
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class DiscussionThread
    {
        public int Id { get; set; }
        public int BacklogItemId { get; set; }
        public string Topic { get; set; }
        public List<DiscussionPost> Posts { get; set; } = new List<DiscussionPost>();


        public void AddPost(DiscussionPost post)
        {
            Posts.Add(post);
        }

        public bool RemovePost(DiscussionPost post)
        {
            return Posts.Remove(post);
        }

        public DiscussionPost GetPost(int id)
        {
            return Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}
