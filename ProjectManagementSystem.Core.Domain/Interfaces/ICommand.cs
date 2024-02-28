

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
