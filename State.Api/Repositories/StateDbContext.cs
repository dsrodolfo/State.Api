using Microsoft.EntityFrameworkCore;
using State.Api.Entities;

namespace State.Api.Repositories
{
    public class StateDbContext : DbContext
    {
        public StateDbContext(DbContextOptions<StateDbContext> options)
            : base(options)
        {

        }

        public DbSet<StateEntity> State { get; set; }  
        public DbSet<CountryEntity> Country { get; set; }
    }
}
