using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Open Opportunity" });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "3Bet Opportunity" });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "DisplayName", "ScenarioId" },
                values: new object[,]
                {
                    { 1, "Unopened Pot", 1 },
                    { 2, "UTG Open", 2 },
                    { 3, "HJ Open", 2 },
                    { 4, "CO Open", 2 },
                    { 5, "BTN Open", 2 },
                    { 6, "SB Open", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
