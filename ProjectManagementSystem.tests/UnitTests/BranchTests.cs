using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class BranchTests
    {
        [Fact]
        public void CanAddCommitToBranch()
        {
            // Arrange
            var branch = new Branch { Name = "Feature" };
            var commit = new Commit { Message = "Initial commit" };

            // Act
            branch.AddCommit(commit);

            // Assert
            Assert.Contains(commit, branch.Commits);
        }

        [Fact]
        public void CanRemoveCommitFromBranch()
        {
            // Arrange
            var branch = new Branch { Name = "Feature" };
            var commit = new Commit { Message = "Initial commit" };
            branch.AddCommit(commit);

            // Act
            bool removed = branch.RemoveCommit(commit);

            // Assert
            Assert.True(removed);
            Assert.DoesNotContain(commit, branch.Commits);
        }
    }
}
