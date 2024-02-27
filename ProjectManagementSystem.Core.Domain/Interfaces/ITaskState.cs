using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface ITaskState
    {
        void Created();
        void InProgress();
        void Review();
        void ReviewNotOK();
        void Test();
        void TestNotOK();
        void Done();
        void Rejected();
    }
}
