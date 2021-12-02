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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 1, Name = "Acre" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 2, Name = "Alagoas" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 3, Name = "Amapá" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 4, Name = "Amazonas" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 5, Name = "Bahia" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 6, Name = "Ceará" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 7, Name = "Distrito Federal" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 8, Name = "Espírito Santo" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 9, Name = "Goiás" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 10, Name = "Maranhão" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 11, Name = "Mato Grosso" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 12, Name = "Mato Grosso do Sul" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 13, Name = "Minas Gerais" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 14, Name = "Pará" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 15, Name = "Paraíba" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 16, Name = "Paraná" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 17, Name = "Pernambuco" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 18, Name = "Piauí" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 19, Name = "Rio de Janeiro" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 20, Name = "Rio Grande do Norte" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 21, Name = "Rio Grande do Sul" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 22, Name = "Rondônia" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 23, Name = "Roraima" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 24, Name = "Santa Catarina" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 25, Name = "São Paulo" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 26, Name = "Sergipe" });
            modelBuilder.Entity<StateEntity>().HasData(new StateEntity { Id = 27, Name = "Tocantins" });
        }
    }
}