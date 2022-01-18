using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PBandJ.Api.Migrations
{
    public partial class Situations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Situation_SituationId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Situation_Scenarios_ScenarioId",
                table: "Situation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Situation",
                table: "Situation");

            migrationBuilder.RenameTable(
                name: "Situation",
                newName: "Situations");

            migrationBuilder.RenameIndex(
                name: "IX_Situation_ScenarioId",
                table: "Situations",
                newName: "IX_Situations_ScenarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Situations",
                table: "Situations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Situations_SituationId",
                table: "Positions",
                column: "SituationId",
                principalTable: "Situations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Situations_Scenarios_ScenarioId",
                table: "Situations",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Situations_SituationId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Situations_Scenarios_ScenarioId",
                table: "Situations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Situations",
                table: "Situations");

            migrationBuilder.RenameTable(
                name: "Situations",
                newName: "Situation");

            migrationBuilder.RenameIndex(
                name: "IX_Situations_ScenarioId",
                table: "Situation",
                newName: "IX_Situation_ScenarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Situation",
                table: "Situation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Situation_SituationId",
                table: "Positions",
                column: "SituationId",
                principalTable: "Situation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Situation_Scenarios_ScenarioId",
                table: "Situation",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
