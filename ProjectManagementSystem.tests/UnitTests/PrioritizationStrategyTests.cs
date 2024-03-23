using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.PrioritizationStrategy;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class PrioritizationStrategyTests
    {
        [Fact]
        public void DeadlinePrioritizationStrategy_Should_Prioritize_Based_On_Deadline()
        {
            // Arrange
            var strategy = new DeadlinePrioritizationStrategy();
            var backlogItem = new BacklogItem(); // You need to create a mock or actual instance of this
            var activity = new Activity(); // Same here, create a mock or actual instance

            // Act
            strategy.Prioritize(backlogItem, activity);

            // Assert
            // Assert something about the prioritization, you would need to have some observable effect
            // Maybe a property on backlogItem or activity changes, and you'd assert on that
        }

        [Fact]
        public void ComplexityPrioritizationStrategy_Should_Prioritize_Based_On_Complexity()
        {
            // Arrange
            var strategy = new ComplexityPrioritizationStrategy();
            var backlogItem = new BacklogItem(); // Create instance or mock
            var activity = new Activity(); // Create instance or mock

            // Act
            strategy.Prioritize(backlogItem, activity);

            // Assert
            // Assert something about the prioritization, based on complexity
        }
    }
}
