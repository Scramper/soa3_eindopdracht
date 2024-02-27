
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface ITaskState
    {
        void SetTask(PmsTask task);
        void MoveToNextState();

        void Created();
        void InProgress();
        void Review();
        void ReviewNotOK();
        void Test();
        void TestNotOK();
        void Done();
        void Rejected();
    }
}
