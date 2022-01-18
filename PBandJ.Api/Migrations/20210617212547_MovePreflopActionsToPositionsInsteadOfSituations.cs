using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class MovePreflopActionsToPositionsInsteadOfSituations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreflopAction_Situations_SituationId",
                table: "PreflopAction");

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

            migrationBuilder.RenameColumn(
                name: "SituationId",
                table: "PreflopAction",
                newName: "PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_PreflopAction_SituationId",
                table: "PreflopAction",
                newName: "IX_PreflopAction_PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreflopAction_Positions_PositionId",
                table: "PreflopAction",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreflopAction_Positions_PositionId",
                table: "PreflopAction");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "PreflopAction",
                newName: "SituationId");

            migrationBuilder.RenameIndex(
                name: "IX_PreflopAction_PositionId",
                table: "PreflopAction",
                newName: "IX_PreflopAction_SituationId");

            migrationBuilder.InsertData(
                table: "PreflopAction",
                columns: new[] { "Id", "ActionType", "ActorsPosition", "SituationId" },
                values: new object[,]
                {
                    { 1, 0, 3, 2 },
                    { 2, 0, 4, 3 },
                    { 3, 0, 5, 4 },
                    { 4, 0, 6, 5 },
                    { 5, 0, 1, 6 },
                    { 6, 0, 3, 7 },
                    { 7, 0, 4, 8 },
                    { 8, 0, 5, 9 },
                    { 9, 0, 6, 10 },
                    { 10, 0, 1, 11 },
                    { 11, 0, 1, 12 },
                    { 12, 1, 2, 12 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PreflopAction_Situations_SituationId",
                table: "PreflopAction",
                column: "SituationId",
                principalTable: "Situations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
