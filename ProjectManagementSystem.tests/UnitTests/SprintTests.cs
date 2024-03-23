using ProjectManagementSystem.Core.Domain.Models;
using System;
using Xunit;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class SprintTests
    {
        [Fact]
        public void CanAddBacklogItemToSprint()
        {
            // Arrange
            var sprint = new Sprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14));
            var backlogItem = new BacklogItem { Id = 1 };

            // Act
            sprint.AddBacklogItem(backlogItem);

            // Assert
            Assert.Contains(backlogItem, sprint.BacklogItems);
        }

        [Fact]
        public void CanRemoveBacklogItemFromSprint()
        {
            // Arrange
            var sprint = new Sprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14));
            var backlogItem = new BacklogItem { Id = 1 };
            sprint.AddBacklogItem(backlogItem);

            // Act
            sprint.RemoveBacklogItem(backlogItem);

            // Assert
            Assert.DoesNotContain(backlogItem, sprint.BacklogItems);
        }

        [Fact]
        public void CannotAddNullBacklogItem()
        {
            // Arrange
            var sprint = new Sprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14));

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => sprint.AddBacklogItem(null));
            Assert.Equal("Backlog item cannot be null. (Parameter 'item')", exception.Message);
        }

        [Fact]
        public void CannotRemoveNullBacklogItem()
        {
            // Arrange
            var sprint = new Sprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14));

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => sprint.RemoveBacklogItem(null));
            Assert.Equal("Backlog item cannot be null. (Parameter 'item')", exception.Message);
        }
    }
}