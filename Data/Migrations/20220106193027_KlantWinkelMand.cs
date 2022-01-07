using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSmartphoneShop.Data.Migrations
{
    public partial class KlantWinkelMand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WinkelMandId",
                table: "Smartphones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WinkelManden",
                columns: table => new
                {
                    WinkelMandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlantId = table.Column<int>(nullable: false),
                    SmartphoneId = table.Column<int>(nullable: false),
                    TotaalPrijs = table.Column<decimal>(nullable: false),
                    BestelDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinkelManden", x => x.WinkelMandId);
                });

            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Gemeente = table.Column<string>(nullable: true),
                    Straat = table.Column<string>(nullable: true),
                    Nummer = table.Column<string>(nullable: true),
                    AangemaaktDatum = table.Column<DateTime>(nullable: false),
                    WinkelMandId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantId);
                    table.ForeignKey(
                        name: "FK_Klanten_WinkelManden_WinkelMandId",
                        column: x => x.WinkelMandId,
                        principalTable: "WinkelManden",
                        principalColumn: "WinkelMandId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_WinkelMandId",
                table: "Smartphones",
                column: "WinkelMandId");

            migrationBuilder.CreateIndex(
                name: "IX_Klanten_WinkelMandId",
                table: "Klanten",
                column: "WinkelMandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Smartphones_WinkelManden_WinkelMandId",
                table: "Smartphones",
                column: "WinkelMandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Smartphones_WinkelManden_WinkelMandId",
                table: "Smartphones");

            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.DropTable(
                name: "WinkelManden");

            migrationBuilder.DropIndex(
                name: "IX_Smartphones_WinkelMandId",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "WinkelMandId",
                table: "Smartphones");
        }
    }
}
