using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States
{
    public class DoingState : IBacklogItemState
    {
        public BacklogItem BacklogItem { get; private set; }
        public bool StateFinished() => false;
        public void NextState() => BacklogItem.State = new ReadyForTestingState(BacklogItem);
        public void PreviousState() => BacklogItem.State = new ToDoState(BacklogItem);

        public DoingState(BacklogItem backlogItem)
        {
            BacklogItem = backlogItem;
        }
    }
}