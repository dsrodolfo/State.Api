using Microsoft.EntityFrameworkCore;

namespace State.Infrastructure.Interfaces
{
    public interface IDbContext
    {
        DbContext Instance { get; }
    }
}