using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States
{
    public class ToDoState : IBacklogItemState
    {
        public BacklogItem BacklogItem { get; private set; }
        public bool StateFinished() => false;
        public void NextState() => BacklogItem.State = new DoingState(BacklogItem);
        public void PreviousState() { /* No previous state from ToDo */ }

        public ToDoState(BacklogItem backlogItem)
        {
            BacklogItem = backlogItem;
        }
    }
}
