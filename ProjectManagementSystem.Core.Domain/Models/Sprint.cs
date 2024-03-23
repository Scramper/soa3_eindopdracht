
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Sprint
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<BacklogItem> BacklogItems { get; private set; }

        public Sprint(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            BacklogItems = new List<BacklogItem>();
        }

        public void AddBacklogItem(BacklogItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Backlog item cannot be null.");
            }

            BacklogItems.Add(item);
        }

        public void RemoveBacklogItem(BacklogItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Backlog item cannot be null.");
            }

            BacklogItems.Remove(item);
        }
    }
}
