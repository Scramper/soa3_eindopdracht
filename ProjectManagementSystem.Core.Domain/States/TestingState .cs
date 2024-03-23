using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Core.Domain.States
{
    public class TestingState : IBacklogItemState
    {
        public BacklogItem BacklogItem { get; private set; }
        public bool StateFinished() => false;
        public void NextState() => BacklogItem.State = new DoneState(BacklogItem);
        public void PreviousState() => BacklogItem.State = new ReadyForTestingState(BacklogItem);

        public TestingState(BacklogItem backlogItem)
        {
            BacklogItem = backlogItem;
        }
    }
}
