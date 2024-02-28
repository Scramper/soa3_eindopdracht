using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;

namespace ProjectManagementSystem.Core.Domain.Factories
{
    public class TaskFactory : ITaskFactory
    {
        public PmsTask CreateTask(string title, string description, DateTime deadline, int complexity, User assignee = null)
        {
            var task = new PmsTask
            {
                Title = title,
                Description = description,
                Deadline = deadline,
                Complexity = complexity,
                TaskState = new CreatedTaskState() // Default initial state
            };

            if (assignee != null)
            {
                task.AssignUser(assignee);
            }

            // Additional logic to determine the initial state can be added here

            return task;
        }
    }
}
