using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoCunha.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_SaldoPessoa_SaldoPessoaIdSaldo",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Conta_SaldoPessoaIdSaldo",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "SaldoPessoaIdSaldo",
                table: "Conta");

            migrationBuilder.AddColumn<int>(
                name: "IdConta",
                table: "SaldoPessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPessoa",
                table: "SaldoPessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumeroAgencia",
                table: "SaldoPessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroConta",
                table: "SaldoPessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SaldoPessoa_IdConta",
                table: "SaldoPessoa",
                column: "IdConta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaldoPessoa_IdPessoa",
                table: "SaldoPessoa",
                column: "IdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_SaldoPessoa_Conta_IdConta",
                table: "SaldoPessoa",
                column: "IdConta",
                principalTable: "Conta",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaldoPessoa_Pessoa_IdPessoa",
                table: "SaldoPessoa",
                column: "IdPessoa",
                principalTable: "Pessoa",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaldoPessoa_Conta_IdConta",
                table: "SaldoPessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_SaldoPessoa_Pessoa_IdPessoa",
                table: "SaldoPessoa");

            migrationBuilder.DropIndex(
                name: "IX_SaldoPessoa_IdConta",
                table: "SaldoPessoa");

            migrationBuilder.DropIndex(
                name: "IX_SaldoPessoa_IdPessoa",
                table: "SaldoPessoa");

            migrationBuilder.DropColumn(
                name: "IdConta",
                table: "SaldoPessoa");

            migrationBuilder.DropColumn(
                name: "IdPessoa",
                table: "SaldoPessoa");

            migrationBuilder.DropColumn(
                name: "NumeroAgencia",
                table: "SaldoPessoa");

            migrationBuilder.DropColumn(
                name: "NumeroConta",
                table: "SaldoPessoa");

            migrationBuilder.AddColumn<int>(
                name: "SaldoPessoaIdSaldo",
                table: "Conta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_SaldoPessoaIdSaldo",
                table: "Conta",
                column: "SaldoPessoaIdSaldo");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_SaldoPessoa_SaldoPessoaIdSaldo",
                table: "Conta",
                column: "SaldoPessoaIdSaldo",
                principalTable: "SaldoPessoa",
                principalColumn: "IdSaldo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
