using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States.TaskStates
{
    public class TestNotOkTaskState : ITaskState
    {
        private PmsTask _task;
        public void SetTask(PmsTask task)
        {
            _task = task;
        }
        public void MoveToNextState()
        {
            _task.TaskState = new InProgressTaskState();
        }

        public void Created()
        {
            throw new NotImplementedException();
        }

        public void Done()
        {
            throw new NotImplementedException();
        }

        public void InProgress()
        {
            throw new NotImplementedException();
        }

        public void Rejected()
        {
            _task.TaskState = new RejectedTaskState();
        }

        public void Review()
        {
            throw new NotImplementedException();
        }

        public void ReviewNotOK()
        {
            throw new NotImplementedException();
        }



        public void Test()
        {
            throw new NotImplementedException();
        }

        public void TestNotOK()
        {
            throw new NotImplementedException();
        }
    }
}
