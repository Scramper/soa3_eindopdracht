
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Branch
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Commit> Commits { get; set; } = new List<Commit>();
        public Pipeline<Commit> Pipeline { get; set; }

        public void AddCommit(Commit commit)
        {
            if (commit == null)
            {
                throw new ArgumentNullException(nameof(commit), "Commit cannot be null.");
            }
            Commits.Add(commit);
            // Trigger the associated pipeline (if any) upon commit
            Pipeline?.Execute(commit);
        }

        public bool RemoveCommit(Commit commit)
        {
            return Commits.Remove(commit);
        }
    }
}
