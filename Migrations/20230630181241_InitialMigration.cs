using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoDeBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "TEXT", nullable: false),
                    AutorId = table.Column<int>(type: "INTEGER", nullable: true),
                    AlugadoPorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.id);
                    table.ForeignKey(
                        name: "FK_livro_Usuarios_AlugadoPorId",
                        column: x => x.AlugadoPorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_livro_autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "autor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_livro_AlugadoPorId",
                table: "livro",
                column: "AlugadoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_livro_AutorId",
                table: "livro",
                column: "AutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "autor");
        }
    }
}
