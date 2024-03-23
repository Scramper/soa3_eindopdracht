using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.States;
using System;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class BacklogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IBacklogItemState _state { get; set; }
        private List<IBacklogItemStateObserver> _observers = new List<IBacklogItemStateObserver>();
        public IBacklogItemState State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyObservers();
            }
        }
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

        public void AddObserver(IBacklogItemStateObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IBacklogItemStateObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this._state);
            }
        }
    }
}