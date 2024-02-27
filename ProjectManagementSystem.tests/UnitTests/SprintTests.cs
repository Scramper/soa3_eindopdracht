using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class SprintTests
    {
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var sprint = new Sprint { Tasks = new List<PmsTask>() };
            var task = new PmsTask { Id = 1, Title = "Test Task" };

            // Act
            sprint.AddTask(task);

            // Assert
            Assert.Contains(task, sprint.Tasks);
        }
    }
}
