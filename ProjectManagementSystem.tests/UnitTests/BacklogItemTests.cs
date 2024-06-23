using Moq;
using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class BacklogItemTests
    {
        [Fact]
        public void Should_Notify_Observers_When_State_Changes()
        {
            // Arrange
            var backlogItem = new BacklogItem();
            var observerMock = new Mock<IBacklogItemStateObserver>();
            backlogItem.AddObserver(observerMock.Object);
            var newState = new ToDoState(backlogItem);

            // Act
            backlogItem.State = newState;

            // Assert
            observerMock.Verify(o => o.Update(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void Should_Add_Observer_Correctly()
        {
            // Arrange
            var backlogItem = new BacklogItem();
            var observerMock = new Mock<IBacklogItemStateObserver>();

            // Act
            backlogItem.AddObserver(observerMock.Object);

            // Assert
            backlogItem.State = new ToDoState(backlogItem);
            observerMock.Verify(o => o.Update(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void Should_Remove_Observer_Correctly()
        {
            // Arrange
            var backlogItem = new BacklogItem();
            var observerMock = new Mock<IBacklogItemStateObserver>();
            backlogItem.AddObserver(observerMock.Object);

            // Act
            backlogItem.RemoveObserver(observerMock.Object);
            backlogItem.State = new ToDoState(backlogItem);

            // Assert
            observerMock.Verify(o => o.Update(It.IsAny<IBacklogItemState>()), Times.Never);
        }
    }
}
