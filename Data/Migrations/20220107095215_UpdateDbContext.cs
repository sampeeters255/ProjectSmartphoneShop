using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSmartphoneShop.Data.Migrations
{
    public partial class UpdateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_WinkelManden_WinkelMandId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_WinkelMandSmartphone_Smartphones_SmartphoneId",
                table: "WinkelMandSmartphone");

            migrationBuilder.DropForeignKey(
                name: "FK_WinkelMandSmartphone_WinkelManden_WinkelmandId",
                table: "WinkelMandSmartphone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WinkelMandSmartphone",
                table: "WinkelMandSmartphone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "WinkelMandSmartphone",
                newName: "WinkelMandSmartphones");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_WinkelMandSmartphone_WinkelmandId",
                table: "WinkelMandSmartphones",
                newName: "IX_WinkelMandSmartphones_WinkelmandId");

            migrationBuilder.RenameIndex(
                name: "IX_WinkelMandSmartphone_SmartphoneId",
                table: "WinkelMandSmartphones",
                newName: "IX_WinkelMandSmartphones_SmartphoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_WinkelMandId",
                table: "Orders",
                newName: "IX_Orders_WinkelMandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinkelMandSmartphones",
                table: "WinkelMandSmartphones",
                column: "WinkelMandSmartphoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_WinkelManden_WinkelMandId",
                table: "Orders",
                column: "WinkelMandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WinkelMandSmartphones_Smartphones_SmartphoneId",
                table: "WinkelMandSmartphones",
                column: "SmartphoneId",
                principalTable: "Smartphones",
                principalColumn: "SmartphoneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WinkelMandSmartphones_WinkelManden_WinkelmandId",
                table: "WinkelMandSmartphones",
                column: "WinkelmandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_WinkelManden_WinkelMandId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_WinkelMandSmartphones_Smartphones_SmartphoneId",
                table: "WinkelMandSmartphones");

            migrationBuilder.DropForeignKey(
                name: "FK_WinkelMandSmartphones_WinkelManden_WinkelmandId",
                table: "WinkelMandSmartphones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WinkelMandSmartphones",
                table: "WinkelMandSmartphones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "WinkelMandSmartphones",
                newName: "WinkelMandSmartphone");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_WinkelMandSmartphones_WinkelmandId",
                table: "WinkelMandSmartphone",
                newName: "IX_WinkelMandSmartphone_WinkelmandId");

            migrationBuilder.RenameIndex(
                name: "IX_WinkelMandSmartphones_SmartphoneId",
                table: "WinkelMandSmartphone",
                newName: "IX_WinkelMandSmartphone_SmartphoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_WinkelMandId",
                table: "Order",
                newName: "IX_Order_WinkelMandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinkelMandSmartphone",
                table: "WinkelMandSmartphone",
                column: "WinkelMandSmartphoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_WinkelManden_WinkelMandId",
                table: "Order",
                column: "WinkelMandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WinkelMandSmartphone_Smartphones_SmartphoneId",
                table: "WinkelMandSmartphone",
                column: "SmartphoneId",
                principalTable: "Smartphones",
                principalColumn: "SmartphoneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WinkelMandSmartphone_WinkelManden_WinkelmandId",
                table: "WinkelMandSmartphone",
                column: "WinkelmandId",
                principalTable: "WinkelManden",
                principalColumn: "WinkelMandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
