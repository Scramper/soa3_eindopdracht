using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using ProjectManagementSystem.Core.Domain.Strategies;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class DeadlinePrioritizationStrategyTests
    {
        [Fact]
        public void Tasks_AreCorrectlyPrioritized_ByDeadline()
        {
            // Arrange
            var strategy = new DeadlinePrioritizationStrategy();
            var tasks = new List<PmsTask>
        {
            new PmsTask { Deadline = new DateTime(2023, 12, 31) },
            new PmsTask { Deadline = new DateTime(2023, 01, 01) }
        };

            // Act
            strategy.Prioritize(tasks);

            // Assert
            Assert.True(tasks[0].Deadline < tasks[1].Deadline);
        }
    }
}
