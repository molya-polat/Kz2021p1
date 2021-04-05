﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class FiremanCitizen_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fireman_Citizens_CitizenId",
                table: "Fireman");

            migrationBuilder.RenameColumn(
                name: "CitizenId",
                table: "Fireman",
                newName: "CitizenId_");

            migrationBuilder.RenameIndex(
                name: "IX_Fireman_CitizenId",
                table: "Fireman",
                newName: "IX_Fireman_CitizenId_");

            migrationBuilder.AddForeignKey(
                name: "FK_Fireman_Citizens_CitizenId_",
                table: "Fireman",
                column: "CitizenId_",
                principalTable: "Citizens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fireman_Citizens_CitizenId_",
                table: "Fireman");

            migrationBuilder.RenameColumn(
                name: "CitizenId_",
                table: "Fireman",
                newName: "CitizenId");

            migrationBuilder.RenameIndex(
                name: "IX_Fireman_CitizenId_",
                table: "Fireman",
                newName: "IX_Fireman_CitizenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fireman_Citizens_CitizenId",
                table: "Fireman",
                column: "CitizenId",
                principalTable: "Citizens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
