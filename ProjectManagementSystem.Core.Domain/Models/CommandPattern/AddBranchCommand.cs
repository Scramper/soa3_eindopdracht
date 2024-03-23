using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.CommandPattern
{
    public class AddBranchCommand : ICommand
    {
        private Repository _repository;
        private Branch _branch;

        public AddBranchCommand(Repository repository, Branch branch)
        {
            _repository = repository;
            _branch = branch;
        }

        public void Execute()
        {
            _repository.AddBranch(_branch);
        }

        public void Undo()
        {
            _repository.RemoveBranch(_branch);
        }
    }
}
