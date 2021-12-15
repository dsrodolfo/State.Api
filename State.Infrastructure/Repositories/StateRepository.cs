using State.Domain.Entities;
using State.Infrastructure.Context;

namespace State.Infrastructure.Repositories
{
    public class StateRepository
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