
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class GitHubClient
    {
        public virtual bool CreateRepo(string name, string description, bool isPrivate)
        {
            return true; // Return true for success, false for failure
        }
    }
}
