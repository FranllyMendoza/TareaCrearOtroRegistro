using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoNuevoRegistro.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DescripcionRol = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
