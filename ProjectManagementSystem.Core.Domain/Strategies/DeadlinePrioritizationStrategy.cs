using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Strategies
{
    public class DeadlinePrioritizationStrategy : IPrioritizationStrategy
    {
        public void Prioritize(List<PmsTask> tasks)
        {
            // Assume each task has a Deadline property
            tasks.Sort((x, y) => DateTime.Compare(x.Deadline, y.Deadline));
        }
    }
}
