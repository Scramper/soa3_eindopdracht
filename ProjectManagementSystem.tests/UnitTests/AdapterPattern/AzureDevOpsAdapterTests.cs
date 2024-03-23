using Moq;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests.AdapterPattern
{
    public class AzureDevOpsAdapterTests
    {
        [Fact]
        public void CreateRepository_CallsAzureDevOpsClientWithCorrectParameters()
        {
            // Arrange
            var mockClient = new Mock<AzureDevOpsClient>();
            var adapter = new AzureDevOpsAdapter { AzureDevOpsClient = mockClient.Object };
            var repository = new Repository
            {
                Name = "TestRepo",
                Description = "A test repository",
                Private = false
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
