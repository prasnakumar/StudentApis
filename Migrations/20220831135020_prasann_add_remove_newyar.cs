using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApis.Migrations
{
    public partial class prasann_add_remove_newyar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "student");

            migrationBuilder.AddColumn<int>(
                name: "year_of_enrollment",
                table: "student",
                type: "int",
                nullable: false,
                defaultValue: 2020);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year_of_enrollment",
                table: "student");

            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NAa");
        }
    }
}
