using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class CorrectPositionsAndHandRangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Positions");

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DisplayName", "Key", "SituationId" },
                values: new object[,]
                {
                    { 1, "UTG", 3, 1 },
                    { 18, "SB", 1, 5 },
                    { 17, "BB", 2, 4 },
                    { 16, "SB", 1, 4 },
                    { 15, "BTN", 6, 4 },
                    { 14, "BB", 2, 3 },
                    { 13, "SB", 1, 3 },
                    { 12, "BTN", 6, 3 },
                    { 11, "CO", 5, 3 },
                    { 10, "BB", 2, 2 },
                    { 9, "SB", 1, 2 },
                    { 8, "BTN", 6, 2 },
                    { 7, "CO", 5, 2 },
                    { 6, "HJ", 4, 2 },
                    { 5, "SB", 1, 1 },
                    { 4, "BTN", 6, 1 },
                    { 3, "CO", 5, 1 },
                    { 2, "HJ", 4, 1 },
                    { 19, "BB", 2, 5 },
                    { 20, "BB", 2, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
