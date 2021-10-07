using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIManuel.Migrations
{
    public partial class FixBrinquedoAddGUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Brinquedos",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "tamanho",
                table: "Brinquedos",
                newName: "Tamanho");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Brinquedos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nomeTipo",
                table: "Brinquedos",
                newName: "NomeTipo");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Brinquedos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Brinquedos",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Brinquedos",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Brinquedos");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Brinquedos",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Tamanho",
                table: "Brinquedos",
                newName: "tamanho");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Brinquedos",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "NomeTipo",
                table: "Brinquedos",
                newName: "nomeTipo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Brinquedos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brinquedos",
                newName: "id");
        }
    }
}
