
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Sprint
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<PmsTask> Tasks { get; set; }

        public void AddTask(PmsTask task)
        {
            Tasks.Add(task);
        }
    }
}
