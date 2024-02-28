using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IStateObserver
    {
        void Update(ITaskState newState);
    }
}
