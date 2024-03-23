using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.FactoryPattern
{
    public class ScrumProjectFactory : IProjectFactory
    {
        public Project CreateProject()
        {
            // Logic to create a Scrum project
            return new Project("Scrum Project", "This is a Scrum project")
            {
                // Initialize the project with Scrum-specific properties or logic
            };
        }
    }
}
