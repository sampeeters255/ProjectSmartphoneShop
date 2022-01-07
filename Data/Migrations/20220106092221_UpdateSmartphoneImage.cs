using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSmartphoneShop.Data.Migrations
{
    public partial class UpdateSmartphoneImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Smartphones_Merken_MerkId",
                table: "Smartphones");

            migrationBuilder.DropTable(
                name: "Merken");

            migrationBuilder.DropIndex(
                name: "IX_Smartphones_MerkId",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "MerkId",
                table: "Smartphones");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Smartphones",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Merk",
                table: "Smartphones",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Smartphones");

            migrationBuilder.DropColumn(
                name: "Merk",
                table: "Smartphones");

            migrationBuilder.AddColumn<int>(
                name: "MerkId",
                table: "Smartphones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Merken",
                columns: table => new
                {
                    MerkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerkNaam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merken", x => x.MerkId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_MerkId",
                table: "Smartphones",
                column: "MerkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Smartphones_Merken_MerkId",
                table: "Smartphones",
                column: "MerkId",
                principalTable: "Merken",
                principalColumn: "MerkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
