using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    public partial class addpropertiestohamlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "HamLogs",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RSTrec",
                table: "HamLogs",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RSTsent",
                table: "HamLogs",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOff",
                table: "HamLogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "HamLogs");

            migrationBuilder.DropColumn(
                name: "RSTrec",
                table: "HamLogs");

            migrationBuilder.DropColumn(
                name: "RSTsent",
                table: "HamLogs");

            migrationBuilder.DropColumn(
                name: "TimeOff",
                table: "HamLogs");
        }
    }
}
