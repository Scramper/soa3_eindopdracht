using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using System;
using Xunit;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class TaskTests
    {
        [Fact]
        public void TaskStateTransition_ToDone_ThrowsInvalidOperationException()
        {
            // Arrange
            var task = new PmsTask
            {
                Title = "Sample Task",
                Description = "This is a sample task.",
                TaskState = new CreatedTaskState()
            };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new DoneTaskState()));
        }

        [Fact]
        public void AssignUser_AssignsUserToTask()
        {
            // Arrange
            var task = new PmsTask();
            var user = new User { Id = 1, Name = "John Doe" };

            // Act
            task.AssignUser(user);

            // Assert
            Assert.Equal(user, task.Assignee);
        }

        [Fact]
        public void AddBacklogItem_AddsItemToProject()
        {
            // Arrange
            var project = new Project(new SimplePrioritizationStrategy());
            var task = new PmsTask { Title = "New Task", Description = "New task description" };
            var backlogItem = new BacklogItem(task);

            // Act
            project.AddBacklogItem(backlogItem);

            // Assert
            Assert.Contains(backlogItem, project.Backlog.Items);
        }
    }

    // A simple prioritization strategy for demonstration purposes
    public class SimplePrioritizationStrategy : IPrioritizationStrategy
    {
        public void Prioritize(System.Collections.Generic.List<PmsTask> tasks)
        {
            // Simple prioritization logic (not implemented for this example)
        }
    }
}
