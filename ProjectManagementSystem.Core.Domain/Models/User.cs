using ProjectManagementSystem.Core.Domain.Enums;
using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class User : IStateObserver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public ITaskState LastNotifiedState { get; private set; }
        public void Update(ITaskState newState)
        {
            LastNotifiedState = newState;
            Console.WriteLine($"Notification: Task state has changed to {newState.GetType().Name}.");
        }
    }
}
