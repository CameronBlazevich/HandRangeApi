using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class AddDataFor3BetDefense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DisplayName", "Key", "SituationId" },
                values: new object[,]
                {
                    { 27, "BTN", 6, 12 },
                    { 28, "CO", 5, 12 },
                    { 29, "HJ", 4, 12 },
                    { 30, "UTG", 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "DisplayName", "ScenarioId" },
                values: new object[,]
                {
                    { 13, "SB 3Bet", 4 },
                    { 14, "BTN 3Bet", 4 },
                    { 15, "CO 3Bet", 4 },
                    { 16, "HJ 3Bet", 4 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DisplayName", "Key", "SituationId" },
                values: new object[,]
                {
                    { 31, "BTN", 6, 13 },
                    { 32, "CO", 5, 13 },
                    { 33, "HJ", 4, 13 },
                    { 34, "UTG", 3, 13 },
                    { 35, "CO", 5, 14 },
                    { 36, "HJ", 4, 14 },
                    { 37, "UTG", 3, 14 },
                    { 38, "HJ", 4, 15 },
                    { 39, "UTG", 3, 15 },
                    { 40, "UTG", 3, 16 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
