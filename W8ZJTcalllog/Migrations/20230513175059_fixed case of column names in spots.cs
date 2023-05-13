using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    public partial class fixedcaseofcolumnnamesinspots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Spots",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "Freq",
                table: "Spots",
                newName: "freq");

            migrationBuilder.RenameColumn(
                name: "Dxcall",
                table: "Spots",
                newName: "dxcall");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Spots",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Call",
                table: "Spots",
                newName: "call");

            migrationBuilder.RenameColumn(
                name: "Band",
                table: "Spots",
                newName: "band");

            migrationBuilder.RenameColumn(
                name: "Nr",
                table: "Spots",
                newName: "nr");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_Time_Band",
                table: "Spots",
                newName: "IX_Spots_time_band");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_Freq",
                table: "Spots",
                newName: "IX_Spots_freq");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_Dxcall",
                table: "Spots",
                newName: "IX_Spots_dxcall");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_Band",
                table: "Spots",
                newName: "IX_Spots_band");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "time",
                table: "Spots",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "freq",
                table: "Spots",
                newName: "Freq");

            migrationBuilder.RenameColumn(
                name: "dxcall",
                table: "Spots",
                newName: "Dxcall");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Spots",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "call",
                table: "Spots",
                newName: "Call");

            migrationBuilder.RenameColumn(
                name: "band",
                table: "Spots",
                newName: "Band");

            migrationBuilder.RenameColumn(
                name: "nr",
                table: "Spots",
                newName: "Nr");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_time_band",
                table: "Spots",
                newName: "IX_Spots_Time_Band");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_freq",
                table: "Spots",
                newName: "IX_Spots_Freq");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_dxcall",
                table: "Spots",
                newName: "IX_Spots_Dxcall");

            migrationBuilder.RenameIndex(
                name: "IX_Spots_band",
                table: "Spots",
                newName: "IX_Spots_Band");
        }
    }
}
