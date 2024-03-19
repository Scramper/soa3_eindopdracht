﻿
using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Strategies;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PmsTask> Tasks { get; set; }
        public List<Sprint> Sprints { get; set; }
        public Team Team { get; set; }

        private IPrioritizationStrategy prioritizationStrategy;

        public Backlog Backlog { get; set; } = new Backlog();

        public Project(IPrioritizationStrategy initialStrategy)
        {
            prioritizationStrategy = initialStrategy;
            Tasks = new List<PmsTask>();
            Sprints = new List<Sprint>();
        }

        public void AddTask(PmsTask task)
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
        public void AddBacklogItem(BacklogItem item)
        {
            Backlog.AddItem(item);
        }

        //Strategy pattern methods
        public void SetPrioritizationStrategy(IPrioritizationStrategy strategy)
        {
            prioritizationStrategy = strategy;
        }

        public void PrioritizeTasks()
        {
            prioritizationStrategy.Prioritize(Tasks);
        }

    }
}
