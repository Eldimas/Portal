using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApp.API.Migrations
{
    public partial class updateRegions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Regions",
                newName: "NameRu");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameKz",
                table: "Regions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "NameKz",
                table: "Regions");

            migrationBuilder.RenameColumn(
                name: "NameRu",
                table: "Regions",
                newName: "Name");
        }
    }
}
