using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace State.Infrastructure.Migrations
{
    public partial class AddAbbreviationProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "State",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                column: "Abbreviation",
                value: "AC");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2,
                column: "Abbreviation",
                value: "AL");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3,
                column: "Abbreviation",
                value: "AP");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4,
                column: "Abbreviation",
                value: "AM");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5,
                column: "Abbreviation",
                value: "BA");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6,
                column: "Abbreviation",
                value: "CE");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7,
                column: "Abbreviation",
                value: "DF");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8,
                column: "Abbreviation",
                value: "ES");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9,
                column: "Abbreviation",
                value: "GO");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10,
                column: "Abbreviation",
                value: "MA");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 11,
                column: "Abbreviation",
                value: "MT");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 12,
                column: "Abbreviation",
                value: "MS");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 13,
                column: "Abbreviation",
                value: "MG");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 14,
                column: "Abbreviation",
                value: "PA");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 15,
                column: "Abbreviation",
                value: "PB");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 16,
                column: "Abbreviation",
                value: "PR");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 17,
                column: "Abbreviation",
                value: "PE");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 18,
                column: "Abbreviation",
                value: "PI");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 19,
                column: "Abbreviation",
                value: "RJ");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 20,
                column: "Abbreviation",
                value: "RN");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 21,
                column: "Abbreviation",
                value: "RS");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 22,
                column: "Abbreviation",
                value: "RO");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 23,
                column: "Abbreviation",
                value: "RR");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 24,
                column: "Abbreviation",
                value: "SC");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 25,
                column: "Abbreviation",
                value: "SP");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 26,
                column: "Abbreviation",
                value: "SE");

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 27,
                column: "Abbreviation",
                value: "TO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "State");
        }
    }
}
