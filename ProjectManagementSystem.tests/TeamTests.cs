using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.tests
{
    public class TeamTests
    {
        [Fact]
        public void AddMember_ShouldAddUserToList()
        {
            // Arrange
            var team = new Team { Members = new List<User>() };
            var user = new User { Id = 1, Name = "Test User" };

            // Act
            team.AddMember(user);

            // Assert
            Assert.Contains(user, team.Members);
        }
    }
}
