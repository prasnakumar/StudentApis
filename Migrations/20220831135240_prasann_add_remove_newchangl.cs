using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApis.Migrations
{
    public partial class prasann_add_remove_newchangl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "student",
                keyColumn: "Id",
                keyValue: 1,
                column: "section",
                value: "A");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "student",
                keyColumn: "Id",
                keyValue: 1,
                column: "section",
                value: null);
        }
    }
}
