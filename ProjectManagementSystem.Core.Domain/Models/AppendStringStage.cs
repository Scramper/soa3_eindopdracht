using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class AppendStringStage : IPipelineStage<string>
    {
        private readonly string _toAppend;

        public AppendStringStage(string toAppend)
        {
            _toAppend = toAppend;
        }

        public string Process(string input)
        {
            return input + _toAppend;
        }
    }
}
