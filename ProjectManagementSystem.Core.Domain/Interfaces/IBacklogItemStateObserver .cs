
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IBacklogItemStateObserver
    {
        void Update(IBacklogItemState newState);
    }
}
