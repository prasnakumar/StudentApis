using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApis.Migrations
{
    public partial class prasann_add_remove_pas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentClass = table.Column<int>(type: "int", nullable: false),
                    section = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "NAa")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "student",
                columns: new[] { "Id", "RollNumber", "StudentClass", "StudentName" },
                values: new object[] { 1, "prasanna1", 5, "prasanna" });

            migrationBuilder.InsertData(
                table: "student",
                columns: new[] { "Id", "RollNumber", "StudentClass", "StudentName" },
                values: new object[] { 2, "Ace2", 5, "Ace" });

            migrationBuilder.InsertData(
                table: "student",
                columns: new[] { "Id", "RollNumber", "StudentClass", "StudentName" },
                values: new object[] { 3, "Yuno3", 5, "Yuno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
