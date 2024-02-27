using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Sprint> Sprints { get; set; }
        public Team Team { get; set; }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void AddSprint(Sprint sprint)
        {
            Sprints.Add(sprint);
        }

        public void AddTeam(Team team)
        {
            Team = team;
        }
    }
}
