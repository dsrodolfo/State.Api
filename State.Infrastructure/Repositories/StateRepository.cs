using State.Domain.Entities;
using State.Infrastructure.Context;
using State.Infrastructure.Interfaces;

namespace State.Infrastructure.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly StateDbContext _context;

        public StateRepository(StateDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StateEntity> GetAllStates()
        {
            return _context.State;
        }
    }
}