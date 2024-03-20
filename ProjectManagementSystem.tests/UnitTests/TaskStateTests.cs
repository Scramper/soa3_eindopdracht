using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.TaskStates;
using Xunit;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class TaskStateTests
    {
        [Fact]
        public void Task_InitialState_IsCreated()
        {
            // Arrange & Act
            var task = new PmsTask();

            // Assert
            Assert.IsType<CreatedTaskState>(task.TaskState);
        }
        [Fact]
        public void Task_CanTransition_FromCreatedToInProgress()
        {
            // Arrange
            var task = new PmsTask(); // Initially in Created state
            ITaskState newState = new InProgressTaskState();

            // Act
            task.MoveToNextState(newState); // Assuming this moves it to InProgress

            // Assert
            Assert.IsType<InProgressTaskState>(task.TaskState);
        }

        [Fact]
        public void Transition_FromCreatedToDone_ThrowsException()
        {
            var task = new PmsTask { TaskState = new CreatedTaskState() };
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new DoneTaskState()));
        }

        [Fact]
        public void Transition_FromReviewNotOkToReview_ThrowsException()
        {
            var task = new PmsTask { TaskState = new ReviewNotOkTaskState() };
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new ReviewTaskState()));
        }

        [Fact]
        public void Transition_FromReviewNotOkToTest_ThrowsException()
        {
            var task = new PmsTask { TaskState = new ReviewNotOkTaskState() };
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new TestTaskState()));
        }

        [Fact]
        public void Transition_FromTestNotOkToReview_ThrowsException()
        {
            var task = new PmsTask { TaskState = new TestNotOkTaskState() };
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new ReviewTaskState()));
        }

        [Fact]
        public void Transition_FromTestNotOkToDone_ThrowsException()
        {
            var task = new PmsTask { TaskState = new TestNotOkTaskState() };
            Assert.Throws<InvalidOperationException>(() => task.MoveToNextState(new DoneTaskState()));
        }

        [Fact]
        public void Valid_Transition_DoesNotThrowException()
        {
            // Example of a valid transition, adjust according to your state model
            var task = new PmsTask { TaskState = new CreatedTaskState() };
            var noExceptionThrown = Record.Exception(() => task.MoveToNextState(new InProgressTaskState()));
            Assert.Null(noExceptionThrown);
        }
    }
}
