using ProjectManagementSystem.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.States
{
    public class CreatedTaskState : ITaskState
    {
        public void Created()
        {
            throw new NotImplementedException();
        }

        public void Done()
        {
            throw new NotImplementedException();
        }

        public void InProgress()
        {
            throw new NotImplementedException();
        }

        public void Rejected()
        {
            throw new NotImplementedException();
        }

        public void Review()
        {
            throw new NotImplementedException();
        }

        public void ReviewNotOK()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        public void TestNotOK()
        {
            throw new NotImplementedException();
        }
    }
}
