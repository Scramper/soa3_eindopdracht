using ProjectManagementSystem.Core.Domain.Interfaces;


namespace ProjectManagementSystem.Core.Domain.Decorators
{
    public class DeadlineNotificationDecorator : TaskDecorator
    {
        public DeadlineNotificationDecorator(ITaskComponent task) : base(task) { }

        public override void Execute()
        {
            // Execute base task logic
            base.Execute();

            // Check if the deadline is within 2 days from now and notify
            if (Deadline.Subtract(DateTime.Now).TotalDays <= 2)
            {
                Notify();
            }
        }

        private void Notify()
        {
            Console.WriteLine($"Notification: The deadline for the task is approaching ({Deadline}).");
        }
    }
}
