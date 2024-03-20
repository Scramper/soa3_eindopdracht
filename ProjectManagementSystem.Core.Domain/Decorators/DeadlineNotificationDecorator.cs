using ProjectManagementSystem.Core.Domain.Interfaces;


namespace ProjectManagementSystem.Core.Domain.Decorators
{
    public class DeadlineNotificationDecorator : TaskDecorator
    {
        private readonly INotificationService _notificationService;
        public DeadlineNotificationDecorator(ITaskComponent task, INotificationService notificationService)
            : base(task)
        {
            _notificationService = notificationService;
        }

        public override void Execute()
        {
            base.Execute();

            if (Deadline.Subtract(DateTime.Now).TotalDays <= 2)
            {
                _notificationService.Notify($"Notification: The deadline for the task is approaching ({Deadline}).");
            }
        }
    }
}
