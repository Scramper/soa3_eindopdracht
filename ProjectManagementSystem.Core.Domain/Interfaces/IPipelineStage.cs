
namespace ProjectManagementSystem.Core.Domain.Interfaces
{
    public interface IPipelineStage<T>
    {
        T Process(T input);
    }
}
