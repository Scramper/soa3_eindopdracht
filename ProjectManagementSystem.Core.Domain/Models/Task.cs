using ProjectManagementSystem.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public ITaskState TaskState { get; set; }

        public void AssignUser(User user)
        {
            Assignee = user;
        }
    }
}
