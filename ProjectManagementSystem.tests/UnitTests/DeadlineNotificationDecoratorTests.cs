using Moq;
using ProjectManagementSystem.Core.Domain.Decorators;
using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class DeadlineNotificationDecoratorTests
    {
        [Fact]
        public void Execute_Notifies_WhenDeadlineIsApproaching()
        {
            // Arrange
            var mockNotificationService = new Mock<INotificationService>();
            DateTime approachingDeadline = DateTime.Now.AddDays(1); // Simulate an approaching deadline
            var task = new Mock<ITaskComponent>();
            task.Setup(t => t.Deadline).Returns(approachingDeadline);

            var decoratedTask = new DeadlineNotificationDecorator(task.Object, mockNotificationService.Object);

            // Act
            decoratedTask.Execute();

            // Assert
            mockNotificationService.Verify(s => s.Notify(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void Execute_DoesNotNotify_WhenDeadlineIsNotApproaching()
        {
            // Arrange
            var mockNotificationService = new Mock<INotificationService>();
            DateTime distantDeadline = DateTime.Now.AddDays(10); // Simulate a deadline that's not close
            var task = new Mock<ITaskComponent>();
            task.Setup(t => t.Deadline).Returns(distantDeadline);

            var decoratedTask = new DeadlineNotificationDecorator(task.Object, mockNotificationService.Object);

            // Act
            decoratedTask.Execute();

            // Assert
            mockNotificationService.Verify(s => s.Notify(It.IsAny<string>()), Times.Never);
        }
    }
}
