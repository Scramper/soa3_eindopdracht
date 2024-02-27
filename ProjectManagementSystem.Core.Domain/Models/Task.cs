using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public ITaskState TaskState { get; set; }

        public void AssignUser(User user)
        {
            Assignee = user;
        }
    }
}
