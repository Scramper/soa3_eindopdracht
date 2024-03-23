using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Pipeline<T>
    {
        private readonly List<IPipelineStage<T>> _stages = new List<IPipelineStage<T>>();
        public Branch TargetBranch { get; private set; } // Link to a specific branch

        public Pipeline(Branch targetBranch)
        {
            TargetBranch = targetBranch;
        }

        public void AddStage(IPipelineStage<T> stage)
        {
            _stages.Add(stage);
        }
        public int GetStageCount()
        {
            return _stages.Count;
        }

        public T Execute(T input)
        {
            T current = input;
            foreach (var stage in _stages)
            {
                current = stage.Process(current);
            }
            // Optionally, record pipeline execution results here
            return current;
        }
    }
}
