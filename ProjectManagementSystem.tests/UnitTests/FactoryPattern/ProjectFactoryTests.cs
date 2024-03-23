using ProjectManagementSystem.Core.Domain.Models.FactoryPattern;

namespace ProjectManagementSystem.Tests.UnitTests.FactoryPattern
{
    public class ProjectFactoryTests
    {
        [Fact]
        public void KanbanProjectFactory_CreatesProject_ProjectIsNotNullAndCorrectlyInitialized()
        {
            // Arrange
            var factory = new KanbanProjectFactory();

            // Act
            var project = factory.CreateProject();

            // Assert
            Assert.NotNull(project);
            Assert.Equal("Kanban Project", project.Name);
            Assert.Equal("This is a Kanban project", project.Description);
            // Add more asserts if you need to check other properties
        }
    }
}
