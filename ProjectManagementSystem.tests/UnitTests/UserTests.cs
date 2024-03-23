using ProjectManagementSystem.Core.Domain.Enums;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class UserTests
    {
        [Fact]
        public void User_ShouldBeCreated_WithDeveloperRole()
        {
            // Arrange
            var userName = "John Doe";
            var userRole = Role.Developer;

            // Act
            var user = new User(userName, userRole);

            // Assert
            Assert.Equal(userName, user.Name);
            Assert.Equal(userRole, user.UserRole);
        }

        [Fact]
        public void User_ShouldBeCreated_WithAdministratorRole()
        {
            // Arrange
            var userName = "Jane Doe";
            var userRole = Role.Administrator;

            // Act
            var user = new User(userName, userRole);

            // Assert
            Assert.Equal(userName, user.Name);
            Assert.Equal(userRole, user.UserRole);
        }
    }
}