using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class SeedInitialPreflopActionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PreflopAction",
                columns: new[] { "Id", "ActionType", "ActorsPosition", "PositionId" },
                values: new object[,]
                {
                    { 1, 0, 3, 6 },
                    { 22, 1, 2, 26 },
                    { 21, 0, 1, 26 },
                    { 20, 0, 1, 25 },
                    { 19, 0, 6, 24 },
                    { 18, 0, 5, 23 },
                    { 17, 0, 4, 22 },
                    { 16, 0, 3, 21 },
                    { 15, 0, 1, 20 },
                    { 14, 0, 6, 19 },
                    { 13, 0, 6, 18 },
                    { 12, 0, 5, 17 },
                    { 11, 0, 5, 16 },
                    { 10, 0, 5, 15 },
                    { 9, 0, 4, 14 },
                    { 8, 0, 4, 13 },
                    { 7, 0, 4, 12 },
                    { 6, 0, 4, 11 },
                    { 5, 0, 3, 10 },
                    { 4, 0, 3, 9 },
                    { 3, 0, 3, 8 },
                    { 2, 0, 3, 7 },
                    { 23, 0, 6, 27 },
                    { 24, 1, 2, 27 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PreflopAction",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
