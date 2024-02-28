using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using ProjectManagementSystem.Core.Domain.Strategies;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class ComplexityPrioritizationStrategyTests
    {
        [Fact]
        public void Tasks_AreCorrectlyPrioritized_ByComplexity()
        {
            // Arrange
            var strategy = new ComplexityPrioritizationStrategy();
            var tasks = new List<PmsTask>
        {
            new PmsTask { Complexity = 5 },
            new PmsTask { Complexity = 1 }
        };

            // Act
            strategy.Prioritize(tasks);

            // Assert
            Assert.True(tasks[0].Complexity < tasks[1].Complexity);
        }
    }

}
