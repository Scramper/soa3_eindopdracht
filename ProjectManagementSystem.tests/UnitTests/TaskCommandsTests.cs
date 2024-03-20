using ProjectManagementSystem.Core.Domain.Commands;
using ProjectManagementSystem.Core.Domain.Invokers;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class TaskCommandsTests
    {
        [Fact]
        public void Execute_UpdatesTaskDescription()
        {
            // Arrange
            var task = new PmsTask { Description = "Initial Description" };
            var newDescription = "Updated Description";
            var command = new UpdateTaskDescriptionCommand(task, newDescription);

            // Act
            command.Execute();

            // Assert
            Assert.Equal(newDescription, task.Description);
        }
        [Fact]
        public void Undo_RevertsTaskDescriptionToPreviousState()
        {
            // Arrange
            var initialDescription = "Initial Description";
            var task = new PmsTask { Description = initialDescription };
            var command = new UpdateTaskDescriptionCommand(task, "Updated Description");

            // Act
            command.Execute(); // Update the description
            command.Undo(); // Undo the update

            // Assert
            Assert.Equal(initialDescription, task.Description);
        }
        [Fact]
        public void CommandInvoker_ExecutesAndUndoesCommands()
        {
            // Arrange
            var task = new PmsTask { Description = "Initial Description" };
            var command = new UpdateTaskDescriptionCommand(task, "Updated Description");
            var invoker = new CommandInvoker();

            // Act
            invoker.ExecuteCommand(command); // Should update the description
            var updatedDescription = task.Description;
            invoker.Undo(); // Should revert the description

            // Assert
            Assert.Equal("Updated Description", updatedDescription);
            Assert.Equal("Initial Description", task.Description);
        }
    }
}
