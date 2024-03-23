using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class RepositoryTests
    {
        [Fact]
        public void CanAddBranchToRepository()
        {
            // Arrange
            var repository = new Repository { Name = "Main Repo" };
            var branch = new Branch { Name = "Develop" };

            // Act
            repository.AddBranch(branch);

            // Assert
            Assert.Contains(branch, repository.Branches);
        }

        [Fact]
        public void CanRemoveBranchFromRepository()
        {
            // Arrange
            var repository = new Repository { Name = "Main Repo" };
            var branch = new Branch { Name = "Develop" };
            repository.AddBranch(branch);

            // Act
            bool removed = repository.RemoveBranch(branch);

            // Assert
            Assert.True(removed);
            Assert.DoesNotContain(branch, repository.Branches);
        }
    }
}
