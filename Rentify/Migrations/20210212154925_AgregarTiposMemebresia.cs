using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class AgregarTiposMemebresia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TipoMembresia (Id, CostoRegistro, DuracionEnMeses, Descuento) VALUES (1, 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO TipoMembresia (Id, CostoRegistro, DuracionEnMeses, Descuento) VALUES (2, 100, 1, 10)");
            migrationBuilder.Sql("INSERT INTO TipoMembresia (Id, CostoRegistro, DuracionEnMeses, Descuento) VALUES (3, 300, 4, 15)");
            migrationBuilder.Sql("INSERT INTO TipoMembresia (Id, CostoRegistro, DuracionEnMeses, Descuento) VALUES (4, 900, 12, 20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
