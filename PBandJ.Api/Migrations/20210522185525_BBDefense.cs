using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class BBDefense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "BB Defense" });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "DisplayName", "OpenerPosition", "ScenarioId" },
                values: new object[,]
                {
                    { 7, "UTG Open", 3, 3 },
                    { 8, "HJ Open", 4, 3 },
                    { 9, "CO Open", 5, 3 },
                    { 10, "BTN Open", 6, 3 },
                    { 11, "SB Open", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DisplayName", "Key", "SituationId" },
                values: new object[,]
                {
                    { 21, "BB", 2, 7 },
                    { 22, "BB", 2, 8 },
                    { 23, "BB", 2, 9 },
                    { 24, "BB", 2, 10 },
                    { 25, "BB", 2, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
