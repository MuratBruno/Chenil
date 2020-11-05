using Microsoft.EntityFrameworkCore.Migrations;

namespace Chenil.Migrations
{
    public partial class AjoutChampsObjet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Objet",
                table: "Message",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Objet",
                table: "Message");
        }
    }
}
