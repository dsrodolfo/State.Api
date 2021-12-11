using Microsoft.EntityFrameworkCore;
using State.Domain.Entities;

namespace State.Infrastructure.Repositories
{
    public class StateDbContext : DbContext
    {
        public StateDbContext(DbContextOptions<StateDbContext> options)
            : base(options) { }

        public DbSet<StateEntity> State { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 1, Name = "Acre", Population = 906876 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 2, Name = "Alagoas", Population = 3365351 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 3, Name = "Amapá", Population = 877613 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 4, Name = "Amazonas", Population = 4269995 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 5, Name = "Bahia", Population = 14985284 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 6, Name = "Ceará", Population = 9240580 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 7, Name = "Distrito Federal", Population = 3094325 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 8, Name = "Espírito Santo", Population = 4108508 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 9, Name = "Goiás", Population = 7206589 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 10, Name = "Maranhão", Population = 7153262 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 11, Name = "Mato Grosso", Population = 3567234 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 12, Name = "Mato Grosso do Sul", Population = 2839188 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 13, Name = "Minas Gerais", Population = 21411923 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 14, Name = "Pará", Population = 8777124 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 15, Name = "Paraíba", Population = 4059905 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 16, Name = "Paraná", Population = 11597484 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 17, Name = "Pernambuco", Population = 9674793 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 18, Name = "Piauí", Population = 3289290 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 19, Name = "Rio de Janeiro", Population = 17463349 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 20, Name = "Rio Grande do Norte", Population = 3560903 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 21, Name = "Rio Grande do Sul", Population = 11466630 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 22, Name = "Rondônia", Population = 1815278 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 23, Name = "Roraima", Population = 652713 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 24, Name = "Santa Catarina", Population = 7338443 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 25, Name = "São Paulo", Population = 41262199 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 26, Name = "Sergipe", Population = 2338474 });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 27, Name = "Tocantins", Population = 1607363 });
        }
    }
}