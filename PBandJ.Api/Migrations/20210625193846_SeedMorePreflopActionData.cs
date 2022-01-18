using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class SeedMorePreflopActionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PreflopAction",
                columns: new[] { "Id", "ActionType", "ActorsPosition", "PositionId" },
                values: new object[,]
                {
                    { 25, 0, 5, 28 },
                    { 48, 1, 5, 39 },
                    { 47, 0, 3, 39 },
                    { 46, 1, 5, 38 },
                    { 45, 0, 4, 38 },
                    { 44, 1, 6, 37 },
                    { 43, 0, 3, 37 },
                    { 42, 1, 6, 36 },
                    { 41, 0, 4, 36 },
                    { 40, 1, 6, 35 },
                    { 39, 0, 5, 35 },
                    { 38, 1, 1, 34 },
                    { 37, 0, 3, 34 },
                    { 36, 1, 1, 33 },
                    { 35, 0, 4, 33 },
                    { 34, 1, 1, 32 },
                    { 33, 0, 5, 32 },
                    { 32, 1, 1, 31 },
                    { 31, 0, 6, 31 },
                    { 30, 1, 2, 30 },
                    { 29, 0, 3, 30 },
                    { 28, 1, 2, 29 },
                    { 27, 0, 4, 29 },
                    { 26, 1, 2, 28 },
                    { 49, 0, 3, 40 },
                    { 50, 1, 4, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
