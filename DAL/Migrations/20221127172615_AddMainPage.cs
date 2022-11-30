using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddMainPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainPage",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    wpm = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainPage");
        }
    }
}
