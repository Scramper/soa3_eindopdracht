using Moq;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class GitHubAdapterTests
    {
        [Fact]
        public void CreateRepository_CallsGitHubClientWithCorrectParameters()
        {
            // Arrange
            var mockClient = new Mock<GitHubClient>();
            var adapter = new GitHubAdapter { GitHubClient = mockClient.Object };
            var repository = new Repository
            {
                Name = "TestRepo",
                Description = "A test repository",
                Private = true
            };

            // Act
            adapter.CreateRepository(repository);

            // Assert
            mockClient.Verify(client => client.CreateRepo(
                It.Is<string>(name => name == repository.Name),
                It.Is<string>(desc => desc == repository.Description),
                It.Is<bool>(isPrivate => isPrivate == repository.Private)),
                Times.Once);
        }
    }
}
