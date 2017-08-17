using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scrum.Migrations
{
    public partial class UpdatePhase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Phase_PhaseId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phase",
                table: "Phase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phases",
                table: "Phase",
                column: "PhaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Phases_PhaseId",
                table: "Tasks",
                column: "PhaseId",
                principalTable: "Phase",
                principalColumn: "PhaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Phase",
                newName: "Phases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Phases_PhaseId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phases",
                table: "Phases");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phase",
                table: "Phases",
                column: "PhaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Phase_PhaseId",
                table: "Tasks",
                column: "PhaseId",
                principalTable: "Phases",
                principalColumn: "PhaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Phases",
                newName: "Phase");
        }
    }
}
