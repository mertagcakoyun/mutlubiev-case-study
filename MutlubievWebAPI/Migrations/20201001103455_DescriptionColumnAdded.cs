using Microsoft.EntityFrameworkCore.Migrations;

namespace MutlubievWebAPI.Migrations
{
    public partial class DescriptionColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HizmetAciklama",
                table: "Hizmetler",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HizmetAciklama",
                table: "Hizmetler");
        }
    }
}
