

using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IPrioritizationStrategy
    {
        void Prioritize(List<PmsTask> tasks);
    }
}
