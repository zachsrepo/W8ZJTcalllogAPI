using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    public partial class addedsomecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastWorkedMode",
                table: "Users",
                type: "varchar(4)",
                maxLength: 4,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "LastWorkedPower",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "showAddressColumn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "showNetColumn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RstRecbool",
                table: "HamLogs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RstSentbool",
                table: "HamLogs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastWorkedMode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastWorkedPower",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "showAddressColumn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "showNetColumn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RstRecbool",
                table: "HamLogs");

            migrationBuilder.DropColumn(
                name: "RstSentbool",
                table: "HamLogs");
        }
    }
}
