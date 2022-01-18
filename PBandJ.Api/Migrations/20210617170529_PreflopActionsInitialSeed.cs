using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class PreflopActionsInitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "3Bet Defense" });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "DisplayName", "ScenarioId" },
                values: new object[] { 12, "BB 3Bet", 4 });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DisplayName", "Key", "SituationId" },
                values: new object[] { 26, "SB", 1, 12 });

            migrationBuilder.InsertData(
                table: "PreflopAction",
                columns: new[] { "Id", "ActionType", "ActorsPosition", "SituationId" },
                values: new object[] { 11, 0, 1, 12 });

            migrationBuilder.InsertData(
                table: "PreflopAction",
                columns: new[] { "Id", "ActionType", "ActorsPosition", "SituationId" },
                values: new object[] { 12, 1, 2, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
