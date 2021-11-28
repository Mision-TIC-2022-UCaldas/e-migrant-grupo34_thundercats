using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Migrantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Entidades_EntidadId",
                table: "Servicios");

            migrationBuilder.AlterColumn<int>(
                name: "EntidadId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                    SituacionLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MigranteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Necesidades",
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
                    table.PrimaryKey("PK_Necesidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Necesidades_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Necesidades_MigranteId",
                table: "Necesidades",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MigranteId",
                table: "Personas",
                column: "MigranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Entidades_EntidadId",
                table: "Servicios",
                column: "EntidadId",
                principalTable: "Entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Entidades_EntidadId",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "Necesidades");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "EntidadId",
                table: "Servicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Entidades_EntidadId",
                table: "Servicios",
                column: "EntidadId",
                principalTable: "Entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
