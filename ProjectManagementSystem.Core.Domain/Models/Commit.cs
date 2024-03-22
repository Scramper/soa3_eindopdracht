
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Commit
    {
        public string Message { get; set; }
        public DateTime CreatedOn { get; set; }
        public User User { get; set; }
        public List<CodeFile> CodeFiles { get; set; } = new List<CodeFile>();
        public BacklogItem BacklogItem { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
    }
}
