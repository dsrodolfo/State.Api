using Microsoft.EntityFrameworkCore;
using State.Domain.Entities;

namespace State.Infrastructure.Context
{
    public class StateDbContext : DbContext
    {
        public StateDbContext(DbContextOptions<StateDbContext> options)
            : base(options) { }

        public DbSet<StateEntity> State { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateEntity>()
                .HasData(new StateEntity { Id = 1, Name = "Acre", Abbreviation = "AC", Capital = "Rio Branco", Population = 906876 },
                         new StateEntity { Id = 2, Name = "Alagoas", Abbreviation = "AL", Capital = "Maceió", Population = 3365351 },
                         new StateEntity { Id = 3, Name = "Amapá", Abbreviation = "AP", Capital = "Macapá", Population = 877613 },
                         new StateEntity { Id = 4, Name = "Amazonas", Abbreviation = "AM", Capital = "Manaus", Population = 4269995 },
                         new StateEntity { Id = 5, Name = "Bahia", Abbreviation = "BA", Capital = "Salvador", Population = 14985284 },
                         new StateEntity { Id = 6, Name = "Ceará", Abbreviation = "CE", Capital = "Fortaleza", Population = 9240580 },
                         new StateEntity { Id = 7, Name = "Distrito Federal", Abbreviation = "DF",Capital = "Brasília", Population = 3094325 },
                         new StateEntity { Id = 8, Name = "Espírito Santo", Abbreviation = "ES", Capital = "Vitória", Population = 4108508 },
                         new StateEntity { Id = 9, Name = "Goiás", Abbreviation = "GO", Capital = "Goiânia", Population = 7206589 },
                         new StateEntity { Id = 10, Name = "Maranhão", Abbreviation = "MA", Capital = "São Luís", Population = 7153262 },
                         new StateEntity { Id = 11, Name = "Mato Grosso", Abbreviation = "MT",Capital = "Cuiabá", Population = 3567234 },
                         new StateEntity { Id = 12, Name = "Mato Grosso do Sul", Abbreviation = "MS", Capital = "Campo Grande", Population = 2839188 },
                         new StateEntity { Id = 13, Name = "Minas Gerais", Abbreviation = "MG", Capital = "Belo Horizonte", Population = 21411923 },
                         new StateEntity { Id = 14, Name = "Pará", Abbreviation = "PA", Capital = "Belém", Population = 8777124 },
                         new StateEntity { Id = 15, Name = "Paraíba", Abbreviation = "PB", Capital = "João Pessoa", Population = 4059905 },
                         new StateEntity { Id = 16, Name = "Paraná", Abbreviation = "PR", Capital = "Curitiba", Population = 11597484 },
                         new StateEntity { Id = 17, Name = "Pernambuco", Abbreviation = "PE", Capital = "Recife", Population = 9674793 },
                         new StateEntity { Id = 18, Name = "Piauí", Abbreviation = "PI", Capital = "Teresina", Population = 3289290 },
                         new StateEntity { Id = 19, Name = "Rio de Janeiro", Abbreviation = "RJ", Capital = "Rio de Janeiro", Population = 17463349 },
                         new StateEntity { Id = 20, Name = "Rio Grande do Norte", Abbreviation = "RN", Capital = "Natal", Population = 3560903 },
                         new StateEntity { Id = 21, Name = "Rio Grande do Sul", Abbreviation = "RS", Capital = "Porto Alegre", Population = 11466630 },
                         new StateEntity { Id = 22, Name = "Rondônia", Abbreviation = "RO", Capital = "Porto Velho", Population = 1815278 },
                         new StateEntity { Id = 23, Name = "Roraima", Abbreviation = "RR", Capital = "Boa Vista", Population = 652713 },
                         new StateEntity { Id = 24, Name = "Santa Catarina", Abbreviation = "SC", Capital = "Florianópolis", Population = 7338443 },
                         new StateEntity { Id = 25, Name = "São Paulo", Abbreviation = "SP", Capital = "São Paulo", Population = 41262199 },
                         new StateEntity { Id = 26, Name = "Sergipe", Abbreviation = "SE", Capital = "Aracaju", Population = 2338474 },
                         new StateEntity { Id = 27, Name = "Tocantins", Abbreviation = "TO", Capital = "Palmas", Population = 1607363 });
        }
    }
}