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
                    Population = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "Acre", 906876 },
                    { 2, "Alagoas", 3365351 },
                    { 3, "Amapá", 877613 },
                    { 4, "Amazonas", 4269995 },
                    { 5, "Bahia", 14985284 },
                    { 6, "Ceará", 9240580 },
                    { 7, "Distrito Federal", 3094325 },
                    { 8, "Espírito Santo", 4108508 },
                    { 9, "Goiás", 7206589 },
                    { 10, "Maranhão", 7153262 },
                    { 11, "Mato Grosso", 3567234 },
                    { 12, "Mato Grosso do Sul", 2839188 },
                    { 13, "Minas Gerais", 21411923 },
                    { 14, "Pará", 8777124 },
                    { 15, "Paraíba", 4059905 },
                    { 16, "Paraná", 11597484 },
                    { 17, "Pernambuco", 9674793 },
                    { 18, "Piauí", 3289290 },
                    { 19, "Rio de Janeiro", 17463349 },
                    { 20, "Rio Grande do Norte", 3560903 },
                    { 21, "Rio Grande do Sul", 11466630 },
                    { 22, "Rondônia", 1815278 },
                    { 23, "Roraima", 652713 },
                    { 24, "Santa Catarina", 7338443 },
                    { 25, "São Paulo", 41262199 },
                    { 26, "Sergipe", 2338474 },
                    { 27, "Tocantins", 1607363 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
