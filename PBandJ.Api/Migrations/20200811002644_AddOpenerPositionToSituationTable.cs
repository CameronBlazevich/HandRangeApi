using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class AddOpenerPositionToSituationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpenerPosition",
                table: "Situations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2,
                column: "OpenerPosition",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3,
                column: "OpenerPosition",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 4,
                column: "OpenerPosition",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 5,
                column: "OpenerPosition",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 6,
                column: "OpenerPosition",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenerPosition",
                table: "Situations");
        }
    }
}
