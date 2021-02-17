using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class AgregoNombreATipoMembresia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "TipoMembresia",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "TipoMembresia");
        }
    }
}
