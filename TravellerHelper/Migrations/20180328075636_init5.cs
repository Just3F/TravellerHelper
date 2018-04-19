using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TravellerHelper.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFlight");

            migrationBuilder.DropTable(
                name: "tblCity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "tblFlight",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityFromId = table.Column<long>(nullable: false),
                    CityToId = table.Column<long>(nullable: false),
                    CreatedById = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SeatsMax = table.Column<int>(nullable: false),
                    SeatsReserved = table.Column<int>(nullable: false),
                    TimeFrom = table.Column<DateTime>(nullable: false),
                    TimeTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFlight", x => x.PKID);
                    table.ForeignKey(
                        name: "FK_tblFlight_tblCity_CityFromId",
                        column: x => x.CityFromId,
                        principalTable: "tblCity",
                        principalColumn: "PKID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblFlight_tblCity_CityToId",
                        column: x => x.CityToId,
                        principalTable: "tblCity",
                        principalColumn: "PKID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblFlight_tblUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "tblUser",
                        principalColumn: "PKID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblFlight_CityFromId",
                table: "tblFlight",
                column: "CityFromId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFlight_CityToId",
                table: "tblFlight",
                column: "CityToId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFlight_CreatedById",
                table: "tblFlight",
                column: "CreatedById");
        }
    }
}
