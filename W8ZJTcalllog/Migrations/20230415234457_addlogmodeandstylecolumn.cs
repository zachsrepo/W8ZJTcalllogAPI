using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    public partial class addlogmodeandstylecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogMode",
                table: "Users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Style",
                table: "Users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogMode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "Users");
        }
    }
}
