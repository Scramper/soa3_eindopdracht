
using ProjectManagementSystem.Core.Domain.Interfaces;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Sprint> Sprints { get; set; }
        public Team Team { get; set; }
        public Backlog Backlog { get; set; } = new Backlog();


        public Project(string name, string description)
        {
            Name = name;
            Description = description;
            Backlog = new Backlog();
            Sprints = new List<Sprint>();
        }

        public void AddSprint(Sprint sprint)
        {
            Sprints.Add(sprint);
        }

        public void AddTeam(Team team)
        {
            Team = team;
        }

        public void AddBacklogItem(BacklogItem item)
        {
            Backlog.AddItem(item);
        }

        public void RemoveBacklogItem(BacklogItem item)
        {
            Backlog.RemoveItem(item);
        }

        public void SetPrioritizationStrategy(IPrioritizationStrategy strategy)
        {
            // Implementation to set the prioritization strategy for the backlog items
        }
    }
}
