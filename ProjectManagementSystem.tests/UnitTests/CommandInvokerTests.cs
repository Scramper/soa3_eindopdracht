using Moq;
using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Invoker;
using ProjectManagementSystem.Core.Domain.Models;

namespace ProjectManagementSystem.Tests.UnitTests
{
    public class CommandInvokerTests
    {
        [Fact]
        public void StoreCommand_ShouldAddCommandToList()
        {
            // Arrange
            var commandInvoker = new CommandInvoker();
            var mockCommand = new Mock<ICommand>();

            // Act
            commandInvoker.StoreCommand(mockCommand.Object);

            // Assert
            // As the _commands list is private, we indirectly test if the command is stored by attempting to execute it.
            commandInvoker.ExecuteCommands();

            // Verify that the Execute method on the mock object was called exactly once.
            mockCommand.Verify(cmd => cmd.Execute(), Times.Once());
        }

        [Fact]
        public void ExecuteCommands_ShouldExecuteAllStoredCommands()
        {
            // Arrange
            var commandInvoker = new CommandInvoker();
            var mockCommand1 = new Mock<ICommand>();
            var mockCommand2 = new Mock<ICommand>();
            commandInvoker.StoreCommand(mockCommand1.Object);
            commandInvoker.StoreCommand(mockCommand2.Object);

            // Act
            commandInvoker.ExecuteCommands();

            // Assert
            // Verify that the Execute method on each mock object was called exactly once.
            mockCommand1.Verify(cmd => cmd.Execute(), Times.Once());
            mockCommand2.Verify(cmd => cmd.Execute(), Times.Once());
        }

        [Fact]
        public void ExecuteCommands_ShouldClearCommandsAfterExecution()
        {
            // Arrange
            var commandInvoker = new CommandInvoker();
            var mockCommand = new Mock<ICommand>();
            commandInvoker.StoreCommand(mockCommand.Object);

            // Act
            commandInvoker.ExecuteCommands();

            // Execute commands again to see if the list was cleared (no executions should occur this time).
            commandInvoker.ExecuteCommands();

            // Assert
            // Verify that the Execute method on the mock object was called exactly once, proving that the list was cleared.
            mockCommand.Verify(cmd => cmd.Execute(), Times.Once());
        }
    }
}
