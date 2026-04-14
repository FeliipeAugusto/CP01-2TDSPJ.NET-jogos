using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desenvolvedoras",
                columns: table => new
                {
                    DesenvolvedoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedoras", x => x.DesenvolvedoraId);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    DesenvolvedoraId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogos_Desenvolvedoras_DesenvolvedoraId",
                        column: x => x.DesenvolvedoraId,
                        principalTable: "Desenvolvedoras",
                        principalColumn: "DesenvolvedoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogos_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogos_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecas",
                columns: table => new
                {
                    BibliotecaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    JogoId = table.Column<int>(type: "int", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorasJogadas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecas", x => x.BibliotecaId);
                    table.ForeignKey(
                        name: "FK_Bibliotecas_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "JogoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bibliotecas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conquistas",
                columns: table => new
                {
                    ConquistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    JogoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conquistas", x => x.ConquistaId);
                    table.ForeignKey(
                        name: "FK_Conquistas_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "JogoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotecas_JogoId",
                table: "Bibliotecas",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotecas_UsuarioId_JogoId",
                table: "Bibliotecas",
                columns: new[] { "UsuarioId", "JogoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conquistas_JogoId",
                table: "Conquistas",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_DesenvolvedoraId",
                table: "Jogos",
                column: "DesenvolvedoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_GeneroId",
                table: "Jogos",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_PublisherId",
                table: "Jogos",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bibliotecas");

            migrationBuilder.DropTable(
                name: "Conquistas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Desenvolvedoras");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
