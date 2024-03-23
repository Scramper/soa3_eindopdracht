using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States
{
    public class ReadyForTestingState : IBacklogItemState
    {
        public BacklogItem BacklogItem { get; private set; }
        public bool StateFinished() => false;
        public void NextState() => BacklogItem.State = new TestingState(BacklogItem);
        public void PreviousState() => BacklogItem.State = new DoingState(BacklogItem);

        public ReadyForTestingState(BacklogItem backlogItem)
        {
            BacklogItem = backlogItem;
        }
    }
}
