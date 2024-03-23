using ProjectManagementSystem.Core.Domain.Models;


namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface ISourceControlAdapter
    {
        void CreateRepository(Repository repository);
    }
}
