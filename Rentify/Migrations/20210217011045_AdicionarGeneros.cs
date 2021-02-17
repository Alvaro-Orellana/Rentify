using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class AdicionarGeneros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (1, 'Acción')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (2, 'Ciencia Ficción')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (3, 'Comedia')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (4, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (5, 'Fantasia')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (6, 'Musical')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (7, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (8, 'Suspenso')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (9, 'Terror')");
            migrationBuilder.Sql("INSERT INTO Genero (Id, Nombre) VALUES (10, 'Documental')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
