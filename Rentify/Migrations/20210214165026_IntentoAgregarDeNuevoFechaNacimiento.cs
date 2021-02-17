using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class IntentoAgregarDeNuevoFechaNacimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Clientes",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Clientes");
        }
    }
}
