using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class ChangePositionColumnNameToKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionEnum",
                table: "Positions",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Positions",
                newName: "PositionEnum");
        }
    }
}
