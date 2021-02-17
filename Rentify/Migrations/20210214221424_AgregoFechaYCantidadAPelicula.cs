using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class AgregoFechaYCantidadAPelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<ushort>(
                name: "CantidadEnStock",
                table: "Peliculas",
                type: "INTEGER",
                nullable: false,
                defaultValue: (ushort)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEstreno",
                table: "Peliculas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadEnStock",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "FechaEstreno",
                table: "Peliculas");
        }
    }
}
