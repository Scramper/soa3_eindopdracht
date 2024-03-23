
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Backlog
    {
        public List<BacklogItem> Items { get; set; } = new List<BacklogItem>();

        public void AddItem(BacklogItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(BacklogItem item)
        {
            Items.Remove(item);
        }
    }
}
