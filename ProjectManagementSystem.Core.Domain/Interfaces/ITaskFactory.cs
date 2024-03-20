using ProjectManagementSystem.Core.Domain.Models;


namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface ITaskFactory
    {
        PmsTask CreateTask(string title, string description, DateTime deadline, int complexity, User assignee = null);
    }
}
