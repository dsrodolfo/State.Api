using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace State.Infrastructure.Migrations
{
    public partial class Add_Gentilic_Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gentilic",
                table: "State",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gentilic",
                value: "Acriano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2,
                column: "Gentilic",
                value: "Alagoano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3,
                column: "Gentilic",
                value: "Amapaense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4,
                column: "Gentilic",
                value: "Amazonense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5,
                column: "Gentilic",
                value: "Baiano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6,
                column: "Gentilic",
                value: "Cearense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7,
                column: "Gentilic",
                value: "Brasiliense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8,
                column: "Gentilic",
                value: "Espírito-Santense ou Capixaba");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9,
                column: "Gentilic",
                value: "Goiano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10,
                column: "Gentilic",
                value: "Maranhense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 11,
                column: "Gentilic",
                value: "Mato-Grossense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 12,
                column: "Gentilic",
                value: "Sul-Mato-Grossense ou Mato-Grossense-do-Sul");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 13,
                column: "Gentilic",
                value: "Mineiro");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 14,
                column: "Gentilic",
                value: "Paraense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 15,
                column: "Gentilic",
                value: "Paraibano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 16,
                column: "Gentilic",
                value: "Paranaense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 17,
                column: "Gentilic",
                value: "Pernambucano");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 18,
                column: "Gentilic",
                value: "Piauiense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 19,
                column: "Gentilic",
                value: "Fluminense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 20,
                column: "Gentilic",
                value: "Norte-Rio-Grandense, Rio-Grandense-do-Norte e Potiguar");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 21,
                column: "Gentilic",
                value: "Gaúcho ou Sul-Rio-Grandense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 22,
                column: "Gentilic",
                value: "Rondoniense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 23,
                column: "Gentilic",
                value: "Roraimense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 24,
                column: "Gentilic",
                value: "Catarinense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 25,
                column: "Gentilic",
                value: "Paulista");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 26,
                column: "Gentilic",
                value: "Sergipano ou Sergipense");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 27,
                column: "Gentilic",
                value: "Tocantinense");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gentilic",
                table: "State");
        }
    }
}
