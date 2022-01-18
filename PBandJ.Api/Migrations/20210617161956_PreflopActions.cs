using Microsoft.EntityFrameworkCore.Migrations;

namespace PBandJ.Api.Migrations
{
    public partial class PreflopActions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenerPosition",
                table: "Situations");

            migrationBuilder.CreateTable(
                name: "PreflopAction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SituationId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActorsPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreflopAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreflopAction_Situations_SituationId",
                        column: x => x.SituationId,
                        principalTable: "Situations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 10, 0, 1, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreflopAction_SituationId",
                table: "PreflopAction",
                column: "SituationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreflopAction");

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

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 7,
                column: "OpenerPosition",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 8,
                column: "OpenerPosition",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 9,
                column: "OpenerPosition",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 10,
                column: "OpenerPosition",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 11,
                column: "OpenerPosition",
                value: 1);
        }
    }
}
