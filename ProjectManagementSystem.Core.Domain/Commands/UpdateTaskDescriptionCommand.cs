using ProjectManagementSystem.Core.Domain.Interfaces;
using ProjectManagementSystem.Core.Domain.Models;


namespace ProjectManagementSystem.Core.Domain.Commands
{
    public class UpdateTaskDescriptionCommand : ICommand
    {
        private readonly PmsTask _task;
        private readonly string _newDescription;
        private string _previousDescription;

        public UpdateTaskDescriptionCommand(PmsTask task, string newDescription)
        {
            _task = task;
            _newDescription = newDescription;
        }

        public void Execute()
        {
            _previousDescription = _task.Description;
            _task.Description = _newDescription;
        }

        public void Undo()
        {
            _task.Description = _previousDescription;
        }
    }
}
