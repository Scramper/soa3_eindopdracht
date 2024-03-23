using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.DecoratorPattern
{
    public class BacklogItemWithTag : IBacklogItem
    {
        private IBacklogItem _backlogItem;
        public string Tag { get; set; }

        public BacklogItemWithTag(IBacklogItem backlogItem, string tag)
        {
            _backlogItem = backlogItem;
            Tag = tag;
        }

        public string GetDetails()
        {
            return $"{_backlogItem.GetDetails()}, Tag: {Tag}";
        }
    }
}
