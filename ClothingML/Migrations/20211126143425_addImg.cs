using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingML.Migrations
{
    public partial class addImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageRef",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRef",
                table: "Product");
        }
    }
}
