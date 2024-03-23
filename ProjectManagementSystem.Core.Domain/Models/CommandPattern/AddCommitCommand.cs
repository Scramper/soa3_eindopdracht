using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models.CommandPattern
{
    public class AddCommitCommand : ICommand
    {
        private Branch _branch;
        private Commit _commit;

        public AddCommitCommand(Branch branch, Commit commit)
        {
            _branch = branch;
            _commit = commit;
        }

        public void Execute()
        {
            _branch.AddCommit(_commit);
        }

        public void Undo()
        {
            _branch.RemoveCommit(_commit);
        }
    }
}
