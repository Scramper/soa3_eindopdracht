using ProjectManagementSystem.Core.Domain.Models;
using Task = ProjectManagementSystem.Core.Domain.Models.Task;

namespace ProjectManagementSystem.tests
{
    public class SprintTests
    {
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var sprint = new Sprint { Tasks = new List<Task>() };
            var task = new Task { Id = 1, Title = "Test Task" };

            // Act
            sprint.AddTask(task);

            // Assert
            Assert.Contains(task, sprint.Tasks);
        }
    }
}
