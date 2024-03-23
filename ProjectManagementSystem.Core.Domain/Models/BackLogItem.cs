using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.States.BacklogItemStates;
using System;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class BacklogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IBacklogItemState State { get; set; }
        public List<Activity> Activities { get; set; }

        public BacklogItem()
        {
            State = new ToDoState(this);
        }
        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }
        public void AddItem(BacklogItem item)
        { /* Implementation */ }
        public void RemoveItem(BacklogItem item)
        { /* Implementation */ }
    }
}