using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.DecoratorPattern
{
    public class BacklogItemWithTag : BacklogItemDecorator
    {
        public string Tag { get; set; }

        public BacklogItemWithTag(IBacklogItem backlogItem, string tag)
            : base(backlogItem)
        {
            Tag = tag;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Tag: {Tag}";
        }
    }

}
