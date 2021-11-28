using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Necesidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Necesidades_Personas_MigranteId",
                table: "Necesidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Necesidades",
                table: "Necesidades");

            migrationBuilder.RenameTable(
                name: "Necesidades",
                newName: "NecesidadesDb");

            migrationBuilder.RenameIndex(
                name: "IX_Necesidades_MigranteId",
                table: "NecesidadesDb",
                newName: "IX_NecesidadesDb_MigranteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NecesidadesDb",
                table: "NecesidadesDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NecesidadesDb_Personas_MigranteId",
                table: "NecesidadesDb",
                column: "MigranteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NecesidadesDb_Personas_MigranteId",
                table: "NecesidadesDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NecesidadesDb",
                table: "NecesidadesDb");

            migrationBuilder.RenameTable(
                name: "NecesidadesDb",
                newName: "Necesidades");

            migrationBuilder.RenameIndex(
                name: "IX_NecesidadesDb_MigranteId",
                table: "Necesidades",
                newName: "IX_Necesidades_MigranteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Necesidades",
                table: "Necesidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Necesidades_Personas_MigranteId",
                table: "Necesidades",
                column: "MigranteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
