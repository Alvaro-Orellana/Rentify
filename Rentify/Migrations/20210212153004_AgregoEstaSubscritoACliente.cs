using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentify.Migrations
{
    public partial class AgregoEstaSubscritoACliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaSubscrito",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaSubscrito",
                table: "Clientes");
        }
    }
}
