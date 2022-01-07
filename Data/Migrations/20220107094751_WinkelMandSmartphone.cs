using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSmartphoneShop.Data.Migrations
{
    public partial class WinkelMandSmartphone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klanten_WinkelManden_WinkelMandId",
                table: "Klanten");

            migrationBuilder.DropForeignKey(
                name: "FK_Smartphones_WinkelManden_WinkelMandId",
                table: "Smartphones");

            migrationBuilder.DropIndex(
                name: "IX_Smartphones_WinkelMandId",
                table: "Smartphones");

            migrationBuilder.DropIndex(
                name: "IX_Klanten_WinkelMandId",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "WinkelMandId",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "AangemaaktDatum",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "Gemeente",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "Nummer",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "Straat",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "WinkelMandId",
                table: "Klanten");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "WinkelManden",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GeboorteDatum",
                table: "Klanten",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gemeente = table.Column<string>(nullable: true),
                    Straat = table.Column<string>(nullable: true),
                    Nummer = table.Column<string>(nullable: true),
                    WinkelMandId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_WinkelManden_WinkelMandId",
                        column: x => x.WinkelMandId,
                        principalTable: "WinkelManden",
                        principalColumn: "WinkelMandId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WinkelMandSmartphone",
                columns: table => new
                {
                    WinkelMandSmartphoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinkelmandId = table.Column<int>(nullable: false),
                    SmartphoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinkelMandSmartphone", x => x.WinkelMandSmartphoneId);
                    table.ForeignKey(
                        name: "FK_WinkelMandSmartphone_Smartphones_SmartphoneId",
                        column: x => x.SmartphoneId,
                        principalTable: "Smartphones",
                        principalColumn: "SmartphoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WinkelMandSmartphone_WinkelManden_WinkelmandId",
                        column: x => x.WinkelmandId,
                        principalTable: "WinkelManden",
                        principalColumn: "WinkelMandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WinkelManden_KlantId",
                table: "WinkelManden",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_WinkelMandId",
                table: "Order",
                column: "WinkelMandId");

            migrationBuilder.CreateIndex(
                name: "IX_WinkelMandSmartphone_SmartphoneId",
                table: "WinkelMandSmartphone",
                column: "SmartphoneId");

            migrationBuilder.CreateIndex(
                name: "IX_WinkelMandSmartphone_WinkelmandId",
                table: "WinkelMandSmartphone",
                column: "WinkelmandId");

            migrationBuilder.AddForeignKey(
                name: "FK_WinkelManden_Klanten_KlantId",
                table: "WinkelManden",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WinkelManden_Klanten_KlantId",
                table: "WinkelManden");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "WinkelMandSmartphone");

            migrationBuilder.DropIndex(
                name: "IX_WinkelManden_KlantId",
                table: "WinkelManden");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "WinkelManden");

            migrationBuilder.DropColumn(
                name: "GeboorteDatum",
                table: "Klanten");

            migrationBuilder.AddColumn<int>(
                name: "WinkelMandId",
                table: "Smartphones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AangemaaktDatum",
                table: "Klanten",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gemeente",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nummer",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Straat",
                table: "Klanten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinkelMandId",
                table: "Klanten",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_WinkelMandId",
                table: "Smartphones",
                column: "WinkelMandId");

            migrationBuilder.CreateIndex(
                name: "IX_Klanten_WinkelMandId",
                table: "Klanten",
                column: "WinkelMandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klanten_WinkelManden_WinkelMandId",
                table: "Klanten",
                column: "WinkelMandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Smartphones_WinkelManden_WinkelMandId",
                table: "Smartphones",
                column: "WinkelMandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
