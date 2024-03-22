
using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class AzureDevOpsAdapter : ISourceControlAdapter
    {
        public AzureDevOpsClient AzureDevOpsClient { get; set; }

        public void CreateRepository(Repository repository)
        {
            AzureDevOpsClient.CreateRepo(repository.Name, repository.Description, repository.Private);
        }
    }
}
