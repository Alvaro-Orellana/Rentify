using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class ActualizoNombresEnTablaTipoMembresia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE TipoMembresia SET Nombre = 'Pago al Contado' WHERE Id = 1");
            migrationBuilder.Sql("UPDATE TipoMembresia SET Nombre = 'Mensual' WHERE Id = 2");
            migrationBuilder.Sql("UPDATE TipoMembresia SET Nombre = 'Cuatrimestral' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE TipoMembresia SET Nombre = 'Anual' WHERE Id = 4");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
