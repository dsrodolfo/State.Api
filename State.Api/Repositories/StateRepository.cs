using State.Api.Entities;

namespace State.Api.Repositories
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