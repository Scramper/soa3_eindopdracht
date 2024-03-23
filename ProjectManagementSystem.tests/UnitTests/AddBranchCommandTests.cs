using ProjectManagementSystem.Core.Domain.Models;
using ProjectManagementSystem.Core.Domain.Models.CommandPattern;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class AddBranchCommandTests
    {
        [Fact]
        public void Execute_Should_AddBranchToRepository()
        {
            // Arrange
            var repository = new Repository { Name = "Main Repo" };
            var branch = new Branch { Name = "Develop" };
            var command = new AddBranchCommand(repository, branch);

            // Act
            command.Execute();

            // Assert
            Assert.Contains(branch, repository.Branches);
        }

        [Fact]
        public void Undo_Should_RemoveBranchFromRepository()
        {
            // Arrange
            var repository = new Repository { Name = "Main Repo" };
            var branch = new Branch { Name = "Develop" };
            var command = new AddBranchCommand(repository, branch);
            command.Execute();

            // Act
            command.Undo();

            // Assert
            Assert.DoesNotContain(branch, repository.Branches);
        }
    }
}
