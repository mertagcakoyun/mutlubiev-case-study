using Microsoft.EntityFrameworkCore.Migrations;

namespace MutlubievWebAPI.Migrations
{
    public partial class PersonellerTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    İl = table.Column<int>(nullable: false),
                    İlce = table.Column<int>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
