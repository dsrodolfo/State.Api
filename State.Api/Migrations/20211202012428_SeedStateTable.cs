using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace State.Api.Migrations
{
    public partial class SeedStateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Acre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
