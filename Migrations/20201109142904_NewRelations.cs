using Microsoft.EntityFrameworkCore.Migrations;

namespace JubiLarian.Migrations
{
    public partial class NewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdProducent",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IdType",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProducent",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdType",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
