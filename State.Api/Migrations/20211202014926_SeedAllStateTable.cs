using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace State.Api.Migrations
{
    public partial class SeedAllStateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Alagoas" },
                    { 3, "Amapá" },
                    { 4, "Amazonas" },
                    { 5, "Bahia" },
                    { 6, "Ceará" },
                    { 7, "Distrito Federal" },
                    { 8, "Espírito Santo" },
                    { 9, "Goiás" },
                    { 10, "Maranhão" },
                    { 11, "Mato Grosso" },
                    { 12, "Mato Grosso do Sul" },
                    { 13, "Minas Gerais" },
                    { 14, "Pará" },
                    { 15, "Paraíba" },
                    { 16, "Paraná" },
                    { 17, "Pernambuco" },
                    { 18, "Piauí" },
                    { 19, "Rio de Janeiro" },
                    { 20, "Rio Grande do Norte" },
                    { 21, "Rio Grande do Sul" },
                    { 22, "Rondônia" },
                    { 23, "Roraima" },
                    { 24, "Santa Catarina" },
                    { 25, "São Paulo" },
                    { 26, "Sergipe" },
                    { 27, "Tocantins" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
