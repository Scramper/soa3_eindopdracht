using System;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class BacklogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PmsTask Task { get; set; } // Associate a task with the backlog item

        public List<PmsTask> Activities { get; set; } = new List<PmsTask>();

        public BacklogItem(PmsTask task)
        {
            Task = task;
            Title = task.Title;
            Description = task.Description;
        }
        public void AddActivity(PmsTask activity)
        {
            Activities.Add(activity);
        }
    }
}