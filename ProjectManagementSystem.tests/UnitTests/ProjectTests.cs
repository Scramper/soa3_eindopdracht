using ProjectManagementSystem.Core.Domain.Models;
using PmsTask = ProjectManagementSystem.Core.Domain.Models.PmsTask;

namespace ProjectManagementSystem.Tests.XunitTests
{
    public class ProjectTests
    {
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var project = new Project { Tasks = new List<PmsTask>() };
            var task = new PmsTask { Id = 1, Title = "Test Task" };

            // Act
            project.AddTask(task);

            // Assert
            Assert.Contains(task, project.Tasks);
        }

        [Fact]
        public void AddSprint_ShouldAddSprintToList()
        {
            // Arrange
            var project = new Project { Sprints = new List<Sprint>() };
            var sprint = new Sprint { Name = "Test Sprint" };

            // Act
            project.AddSprint(sprint);

            // Assert
            Assert.Contains(sprint, project.Sprints);
        }

        [Fact]
        public void AddTeam_ShouldSetProjectTeam()
        {
            // Arrange
            var project = new Project();
            var team = new Team { Id = 1, Name = "Test Team" };

            // Act
            project.AddTeam(team);

            // Assert
            Assert.Equal(team, project.Team);
        }
    }
}
