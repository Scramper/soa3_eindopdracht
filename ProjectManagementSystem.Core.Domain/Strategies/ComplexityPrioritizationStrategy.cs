using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Strategies
{
    public class ComplexityPrioritizationStrategy : IPrioritizationStrategy
    {
        public void Prioritize(List<PmsTask> tasks)
        {
            // Assume each task has a Complexity property (lower means less complex)
            tasks.Sort((x, y) => x.Complexity.CompareTo(y.Complexity));
        }
    }
}
