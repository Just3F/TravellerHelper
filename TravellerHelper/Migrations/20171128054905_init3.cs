using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TravellerHelper.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "tblFlight",
                newName: "CreateDate");

            migrationBuilder.AddColumn<long>(
                name: "CreatedById",
                table: "tblFlight",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_tblFlight_CreatedById",
                table: "tblFlight",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_tblFlight_tblUser_CreatedById",
                table: "tblFlight",
                column: "CreatedById",
                principalTable: "tblUser",
                principalColumn: "PKID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblFlight_tblUser_CreatedById",
                table: "tblFlight");

            migrationBuilder.DropIndex(
                name: "IX_tblFlight_CreatedById",
                table: "tblFlight");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "tblFlight");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "tblFlight",
                newName: "Date");
        }
    }
}
