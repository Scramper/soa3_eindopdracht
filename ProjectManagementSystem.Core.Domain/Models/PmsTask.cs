using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.States.TaskStates;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class PmsTask : ITaskComponent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public DateTime Deadline { get; set; }
        public int Complexity { get; set; }

        private ITaskState _taskState;
        public ITaskState TaskState
        {
            get => _taskState;
            set
            {
                _taskState = value;
                _taskState.SetTask(this);
                NotifyObservers(_taskState);
            }
        }

        private List<IStateObserver> Observers = new List<IStateObserver>();

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
            Attach(user);
        }

        public void Attach(IStateObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IStateObserver observer)
        {
            Observers.Remove(observer);
        }

        protected void NotifyObservers(ITaskState newState)
        {
            foreach (var observer in Observers)
            {
                observer.Update(newState);
            }
        }

        //Decorator pattern methods
        public void Execute()
        {
            // Existing task execution logic
        }
    }
}
