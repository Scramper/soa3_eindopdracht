using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
