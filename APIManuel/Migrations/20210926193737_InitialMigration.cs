using Microsoft.EntityFrameworkCore.Migrations;

namespace APIManuel.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brinquedos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    nomeTipo = table.Column<string>(type: "TEXT", nullable: false),
                    tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    tamanho = table.Column<int>(type: "INTEGER", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brinquedos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brinquedos");
        }
    }
}
