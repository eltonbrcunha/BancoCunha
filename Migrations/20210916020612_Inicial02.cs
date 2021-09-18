using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;
using System;

namespace BancoCunha.Migrations
{
    public partial class Inicial02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovimentacaoBancaria",
                columns: table => new
                {
                    IdMovimentacaoBancaria = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ValorMovimentacao = table.Column<int>(nullable: false),
                    DataMovimentacao = table.Column<DateTime>(nullable: false),
                    NumeroAgencia = table.Column<string>(nullable: true),
                    NumeroConta = table.Column<string>(nullable: true),
                    AutenticacaoMovimentacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentacaoBancaria", x => x.IdMovimentacaoBancaria);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomePessoa = table.Column<string>(nullable: false),
                    DocumentoPessoa = table.Column<string>(nullable: false),
                    TipoPessoa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "SaldoPessoa",
                columns: table => new
                {
                    IdSaldo = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ValorSaldo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaldoPessoa", x => x.IdSaldo);
                });

            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    IdConta = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NumeroConta = table.Column<int>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    NumeroAgencia = table.Column<string>(nullable: true),
                    PessoaIdPessoa = table.Column<int>(nullable: true),
                    SaldoPessoaIdSaldo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.IdConta);
                    table.ForeignKey(
                        name: "FK_Conta_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conta_SaldoPessoa_SaldoPessoaIdSaldo",
                        column: x => x.SaldoPessoaIdSaldo,
                        principalTable: "SaldoPessoa",
                        principalColumn: "IdSaldo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conta_PessoaIdPessoa",
                table: "Conta",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_SaldoPessoaIdSaldo",
                table: "Conta",
                column: "SaldoPessoaIdSaldo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conta");

            migrationBuilder.DropTable(
                name: "MovimentacaoBancaria");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "SaldoPessoa");
        }
    }
}
