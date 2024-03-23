using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.Models.DecoratorPattern;
using Xunit;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class DecoratorTests
    {
        [Fact]
        public void BacklogItemWithTag_ShouldIncludeTagInDetails()
        {
            // Arrange
            IBacklogItem backlogItem = new BacklogItem { Title = "New Feature", Description = "Implement new feature" };
            backlogItem = new BacklogItemWithTag(backlogItem, "Urgent");

            // Act
            var details = backlogItem.GetDetails();

            // Assert
            Assert.Contains("Urgent", details);
            Assert.Contains("New Feature", details);
            Assert.Contains("Implement new feature", details);
        }

        [Fact]
        public void BacklogItemWithoutTag_ShouldNotIncludeTagInDetails()
        {
            // Arrange
            IBacklogItem backlogItem = new BacklogItem { Title = "New Feature", Description = "Implement new feature" };

            // Act
            var details = backlogItem.GetDetails();

            // Assert
            Assert.DoesNotContain("Urgent", details);
        }
    }

}
