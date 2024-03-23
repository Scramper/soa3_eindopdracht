using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.DecoratorPattern
{
    public abstract class BacklogItemDecorator : IBacklogItem
    {
        protected IBacklogItem backlogItem;

        protected BacklogItemDecorator(IBacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public virtual string GetDetails()
        {
            return backlogItem.GetDetails();
        }
    }
}
