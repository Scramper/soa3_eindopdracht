
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Private { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();

        public void AddBranch(Branch branch)
        {
            if (branch == null)
            {
                throw new ArgumentNullException(nameof(branch), "Branch cannot be null.");
            }
            Branches.Add(branch);
        }

        public bool RemoveBranch(Branch branch)
        {
            return Branches.Remove(branch);
        }
    }
}
