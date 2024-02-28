using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using ProjectManagementSystem.Core.Domain.Strategies;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class StrategySwitchingTests
    {
        [Fact]
        public void Strategy_Switching_RePrioritizes_Tasks()
        {
            // Arrange
            var project = new Project(new DeadlinePrioritizationStrategy());
            var tasks = new List<PmsTask>
        {
            new PmsTask { Deadline = new DateTime(2023, 12, 31), Complexity = 1 },
            new PmsTask { Deadline = new DateTime(2023, 01, 01), Complexity = 5 }
        };

            // Prioritize by deadline
            foreach (var task in tasks)
            {
                project.AddTask(task);
            }
            project.PrioritizeTasks();

            // Switch to complexity prioritization
            project.SetPrioritizationStrategy(new ComplexityPrioritizationStrategy());
            project.PrioritizeTasks();

            // Act & Assert - Checking if the first task is now the one with lower complexity
            Assert.True(project.Tasks[0].Complexity < project.Tasks[1].Complexity);
        }
    }
}
