using Moq;
using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States;

namespace ProjectManagementSystem.Tests.UnitTests.ObserverPattern
{
    public class ObserverPatternTests
    {
        public class BacklogItemStateTests
        {
            [Fact]
            public void BacklogItem_Should_Transition_To_New_State()
            {
                // Arrange
                var backlogItem = new BacklogItem();
                var todoState = new ToDoState(backlogItem);
                var doingState = new DoingState(backlogItem);

                // Act
                backlogItem.State = todoState;
                var stateBefore = backlogItem.State;
                backlogItem.State = doingState;
                var stateAfter = backlogItem.State;

                // Assert
                Assert.NotEqual(stateBefore, stateAfter);
                Assert.IsType<DoingState>(stateAfter);
            }

            [Fact]
            public void Observers_Should_Be_Notified_On_State_Change()
            {
                // Arrange
                var backlogItem = new BacklogItem();
                var observerA = new Mock<IBacklogItemStateObserver>();
                var observerB = new Mock<IBacklogItemStateObserver>();
                backlogItem.AddObserver(observerA.Object);
                backlogItem.AddObserver(observerB.Object);
                var newState = new DoingState(backlogItem);

                // Act
                backlogItem.State = newState;

                // Assert
                observerA.Verify(o => o.Update(It.Is<IBacklogItemState>(s => s == newState)), Times.Once());
                observerB.Verify(o => o.Update(It.Is<IBacklogItemState>(s => s == newState)), Times.Once());
            }
        }
    }
}