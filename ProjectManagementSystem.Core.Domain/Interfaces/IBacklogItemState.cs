
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IBacklogItemState
    {
        BacklogItem BacklogItem { get; }
        bool StateFinished();
        void NextState();
        void PreviousState();
    }
}
