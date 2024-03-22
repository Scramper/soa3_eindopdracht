
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Branch
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
    }
}
