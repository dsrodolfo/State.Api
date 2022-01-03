using State.Domain.Entities;

namespace State.Infrastructure.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<StateEntity> GetAllStates();
    }
}