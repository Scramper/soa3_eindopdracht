
using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class GitHubAdapter : ISourceControlAdapter
    {
        public GitHubClient GitHubClient { get; set; }

        public void CreateRepository(Repository repository)
        {
            GitHubClient.CreateRepo(repository.Name, repository.Description, repository.Private);
        }
    }
}
