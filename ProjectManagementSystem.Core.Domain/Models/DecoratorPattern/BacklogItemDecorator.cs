using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.DecoratorPattern
{
    public abstract class BacklogItemDecorator : IBacklogItem
    {

        protected IBacklogItem backlogItem;

        public BacklogItemDecorator(IBacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public string GetDetails()
        {
            throw new NotImplementedException();
        }
    }

}
