using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.FactoryPattern
{
    public class KanbanProjectFactory : IProjectFactory
    {
        public Project CreateProject()
        {
            // Logic to create a Kanban project
            return new Project("Kanban Project", "This is a Kanban project")
            {
                // Initialize the project with Kanban-specific properties or logic
            };
        }
    }
}
