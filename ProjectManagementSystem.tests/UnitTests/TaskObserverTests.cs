using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class TaskObserverTests
    {
        [Fact]
        public void Observer_ReceivesUpdate_OnStateChange()
        {
            // Arrange
            var task = new PmsTask();
            var user = new User();
            task.Attach(user);
            var newState = new InProgressTaskState();

            // Act
            task.TaskState = newState;

            // Assert
            Assert.Equal(newState, user.LastNotifiedState);
        }
        [Fact]
        public void MultipleObservers_AreNotified_OnStateChange()
        {
            // Arrange
            var task = new PmsTask();
            var user1 = new User();
            var user2 = new User();
            task.Attach(user1);
            task.Attach(user2);
            var newState = new InProgressTaskState();

            // Act
            task.TaskState = newState;

            // Assert
            Assert.Equal(newState, user1.LastNotifiedState);
            Assert.Equal(newState, user2.LastNotifiedState);
        }
        [Fact]
        public void DetachedObserver_IsNotNotified_OnStateChange()
        {
            // Arrange
            var task = new PmsTask();
            var user = new User();
            task.Attach(user);
            task.Detach(user);
            var newState = new InProgressTaskState();

            // Act
            task.TaskState = newState;

            // Assert
            Assert.Null(user.LastNotifiedState); // Assuming LastNotifiedState is null by default
        }

    }
}
