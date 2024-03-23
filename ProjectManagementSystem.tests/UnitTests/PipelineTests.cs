using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class PipelineTests
    {
        public class TestStage : IPipelineStage<string>
        {
            public string Process(string input)
            {
                return input.ToUpper(); // A simple processing example
            }
        }

        [Fact]
        public void Pipeline_ExecutesAddedStage_Correctly()
        {
            // Arrange
            var branch = new Branch { Name = "TestBranch" };
            var pipeline = new Pipeline<string>(branch);
            var testStage = new TestStage();
            pipeline.AddStage(testStage);

            string input = "test";
            string expected = "TEST";

            // Act
            var result = pipeline.Execute(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pipeline_AddStage_IncreasesStageCount()
        {
            // Arrange
            var branch = new Branch { Name = "TestBranch" };
            var pipeline = new Pipeline<string>(branch);
            var testStage = new TestStage();

            // Act
            pipeline.AddStage(testStage);

            // Use reflection or modify access level of _stages for testing
            var stageCount = pipeline.GetStageCount(); // This method or property needs to be added for testability

            // Assert
            Assert.Equal(1, stageCount);
        }
    }
}
