using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using TaskFactory = ProjectManagementSystem.Core.Domain.Factories.TaskFactory;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class TaskFactoryTests
    {
        [Fact]
        public void CreateTask_CreatesTaskWithCorrectPropertiesAndDefaultState()
        {
            // Arrange
            var factory = new TaskFactory();
            string expectedTitle = "Implement Feature X";
            string expectedDescription = "Feature X needs to be implemented by Q1.";
            DateTime expectedDeadline = new DateTime(2023, 3, 31);
            int expectedComplexity = 5;

            // Act
            var task = factory.CreateTask(expectedTitle, expectedDescription, expectedDeadline, expectedComplexity);

            // Assert
            Assert.NotNull(task);
            Assert.Equal(expectedTitle, task.Title);
            Assert.Equal(expectedDescription, task.Description);
            Assert.Equal(expectedDeadline, task.Deadline);
            Assert.Equal(expectedComplexity, task.Complexity);
            Assert.IsType<CreatedTaskState>(task.TaskState);
        }
        [Fact]
        public void CreateTask_AssignsUserCorrectlyWhenProvided()
        {
            // Arrange
            var factory = new TaskFactory();
            var expectedUser = new User { Id = 1, Name = "Test User" };
            var task = factory.CreateTask("Fix Bug Y", "Urgent bug fix required.", new DateTime(2023, 4, 15), 2, expectedUser);

            // Act & Assert
            Assert.NotNull(task.Assignee);
            Assert.Equal(expectedUser, task.Assignee);
        }
    }
}
