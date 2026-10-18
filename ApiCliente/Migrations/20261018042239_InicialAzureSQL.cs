using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCliente.Migrations
{
    /// <inheritdoc />
    public partial class InicialAzureSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUI = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    NIT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_cliente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
