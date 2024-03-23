using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.States.BacklogItemStates;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class BacklogItemStateTests
    {
        [Fact]
        public void BacklogItem_InitialState_ShouldBeToDoState()
        {
            var backlogItem = new BacklogItem();
            Assert.IsType<ToDoState>(backlogItem.State);
        }

        [Fact]
        public void ToDoState_NextState_ShouldSetStateToDoingState()
        {
            var backlogItem = new BacklogItem();
            var toDoState = new ToDoState(backlogItem); // Pass the backlog item to the state
            backlogItem.State = toDoState;
            backlogItem.State.NextState();
            Assert.IsType<DoingState>(backlogItem.State);
        }
    }
}
