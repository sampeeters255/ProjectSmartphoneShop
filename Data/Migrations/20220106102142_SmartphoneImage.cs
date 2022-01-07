using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSmartphoneShop.Data.Migrations
{
    public partial class SmartphoneImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Smartphones");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Smartphones",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Smartphones");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Smartphones",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);
        }
    }
}
