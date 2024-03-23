
namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IStateObserver
    {
        void Update(IBacklogItemState newState);
    }
}
