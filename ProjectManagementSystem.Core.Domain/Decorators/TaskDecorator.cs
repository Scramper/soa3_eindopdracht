using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Decorators
{
    public abstract class TaskDecorator : ITaskComponent
    {
        protected ITaskComponent task;

        public TaskDecorator(ITaskComponent task)
        {
            this.task = task;
        }

        public virtual DateTime Deadline => task.Deadline;

        public virtual void Execute()
        {
            task.Execute();
        }
    }
}
