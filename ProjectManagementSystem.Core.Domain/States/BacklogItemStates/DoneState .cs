using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States.BacklogItemStates
{
    public class DoneState : IBacklogItemState
    {
        public BacklogItem BacklogItem { get; private set; }
        public bool StateFinished() => true;
        public void NextState() { /* No next state from Done */ }
        public void PreviousState() => BacklogItem.State = new TestingState(BacklogItem);

        public DoneState(BacklogItem backlogItem)
        {
            BacklogItem = backlogItem;
        }
    }
}
