using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace State.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Capital = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    Population = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Abbreviation", "Capital", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "AC", "Rio Branco", "Acre", 906876 },
                    { 2, "AL", "Maceió", "Alagoas", 3365351 },
                    { 3, "AP", "Macapá", "Amapá", 877613 },
                    { 4, "AM", "Manaus", "Amazonas", 4269995 },
                    { 5, "BA", "Salvador", "Bahia", 14985284 },
                    { 6, "CE", "Fortaleza", "Ceará", 9240580 },
                    { 7, "DF", "Brasília", "Distrito Federal", 3094325 },
                    { 8, "ES", "Vitória", "Espírito Santo", 4108508 },
                    { 9, "GO", "Goiânia", "Goiás", 7206589 },
                    { 10, "MA", "São Luís", "Maranhão", 7153262 },
                    { 11, "MT", "Cuiabá", "Mato Grosso", 3567234 },
                    { 12, "MS", "Campo Grande", "Mato Grosso do Sul", 2839188 },
                    { 13, "MG", "Belo Horizonte", "Minas Gerais", 21411923 },
                    { 14, "PA", "Belém", "Pará", 8777124 },
                    { 15, "PB", "João Pessoa", "Paraíba", 4059905 },
                    { 16, "PR", "Curitiba", "Paraná", 11597484 },
                    { 17, "PE", "Recife", "Pernambuco", 9674793 },
                    { 18, "PI", "Teresina", "Piauí", 3289290 },
                    { 19, "RJ", "Rio de Janeiro", "Rio de Janeiro", 17463349 },
                    { 20, "RN", "Natal", "Rio Grande do Norte", 3560903 },
                    { 21, "RS", "Porto Alegre", "Rio Grande do Sul", 11466630 },
                    { 22, "RO", "Porto Velho", "Rondônia", 1815278 },
                    { 23, "RR", "Boa Vista", "Roraima", 652713 },
                    { 24, "SC", "Florianópolis", "Santa Catarina", 7338443 },
                    { 25, "SP", "São Paulo", "São Paulo", 41262199 },
                    { 26, "SE", "Aracaju", "Sergipe", 2338474 },
                    { 27, "TO", "Palmas", "Tocantins", 1607363 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
