using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    public partial class addedrecordCounttousertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecordCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordCount",
                table: "Users");
        }
    }
}
