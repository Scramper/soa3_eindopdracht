using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.States.TaskStates;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class PmsTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }

        private ITaskState _taskState;
        public ITaskState TaskState
        {
            get => _taskState;
            set
            {
                _taskState = value;
                _taskState.SetTask(this);
            }
        }
        public PmsTask()
        {
            TaskState = new CreatedTaskState(); // Set initial state
        }

        public void MoveToNextState(ITaskState newState)
        {
            if (this.TaskState is CreatedTaskState && newState is DoneTaskState)
            {
                throw new InvalidOperationException("Cannot transition directly from Created to Done.");
            }
            else if (this.TaskState is ReviewNotOkTaskState && newState is ReviewTaskState || newState is TestTaskState)
            {
                throw new InvalidOperationException("Cannot transition directly from ReviewNotOk to Review or Test.");
            }

            else if (this.TaskState is TestNotOkTaskState && newState is ReviewTaskState || newState is DoneTaskState)
            {
                throw new InvalidOperationException("Cannot transition directly from TestNotOk to Review or Done.");
            }

            // If the condition is not met, update the state
            this.TaskState = newState;
        }

        public void AssignUser(User user)
        {
            Assignee = user;
        }
    }
}
