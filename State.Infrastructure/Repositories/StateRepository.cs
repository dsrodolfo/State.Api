using State.Domain.Entities;
using State.Infrastructure.Interfaces;

namespace State.Infrastructure.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly IStateDbContext _context;

        public StateRepository(IStateDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StateEntity> GetAllStates()
        {
            return _context.State;
        }
    }
}