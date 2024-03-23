using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.PrioritizationStrategy
{
    public class DeadlinePrioritizationStrategy : IPrioritizationStrategy
    {
        public void Prioritize(BacklogItem backlogItem, Activity activity)
        {
            // Implementation based on deadline
        }
    }
}
