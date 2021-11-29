using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Migrantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigosyfamiliares1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigosyfamiliares1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nit = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionElectronica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaginaWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDocumento = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacionLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntidadId = table.Column<int>(type: "int", nullable: false),
                    NombreServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxMigrantes = table.Column<int>(type: "int", nullable: false),
                    FechaInicioOferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinOferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Entidades_EntidadId",
                        column: x => x.EntidadId,
                        principalTable: "Entidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmigosyfamiliaresMigrante",
                columns: table => new
                {
                    AmigosYFamiliaresId = table.Column<int>(type: "int", nullable: false),
                    MigranteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmigosyfamiliaresMigrante", x => new { x.AmigosYFamiliaresId, x.MigranteId });
                    table.ForeignKey(
                        name: "FK_AmigosyfamiliaresMigrante_Amigosyfamiliares1_AmigosYFamiliaresId",
                        column: x => x.AmigosYFamiliaresId,
                        principalTable: "Amigosyfamiliares1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmigosyfamiliaresMigrante_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NecesidadesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prioridad = table.Column<int>(type: "int", nullable: false),
                    MigranteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NecesidadesDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NecesidadesDb_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmigosyfamiliaresMigrante_MigranteId",
                table: "AmigosyfamiliaresMigrante",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_NecesidadesDb_MigranteId",
                table: "NecesidadesDb",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_EntidadId",
                table: "Servicios",
                column: "EntidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmigosyfamiliaresMigrante");

            migrationBuilder.DropTable(
                name: "NecesidadesDb");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Amigosyfamiliares1");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Entidades");
        }
    }
}
