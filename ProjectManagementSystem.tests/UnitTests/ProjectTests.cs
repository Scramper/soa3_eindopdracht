using Moq;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class ProjectTests
    {
        [Fact]
        public void Project_Should_Be_Created_With_Name_And_Description()
        {
            // Arrange
            var name = "Project X";
            var description = "A new project";

            // Act
            var project = new Project(name, description);

            // Assert
            Assert.Equal(name, project.Name);
            Assert.Equal(description, project.Description);
        }

        // Add more tests for other methods of Project class
    }
}
