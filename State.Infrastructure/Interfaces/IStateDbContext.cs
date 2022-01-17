using Microsoft.EntityFrameworkCore;
using State.Domain.Entities;

namespace State.Infrastructure.Interfaces
{
    public interface IStateDbContext : IDbContext
    {
        public DbSet<StateEntity> State { get; set; }
    }
}
