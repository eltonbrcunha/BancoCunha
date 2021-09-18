using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoCunha.Migrations
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaldoPessoa_Conta_IdConta",
                table: "SaldoPessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_SaldoPessoa_Pessoa_IdPessoa",
                table: "SaldoPessoa");

            migrationBuilder.AlterColumn<int>(
                name: "IdPessoa",
                table: "SaldoPessoa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdConta",
                table: "SaldoPessoa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoMovimentacao",
                table: "MovimentacaoBancaria",
                type: "text",
                nullable: true);

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

            migrationBuilder.DropColumn(
                name: "TipoMovimentacao",
                table: "MovimentacaoBancaria");

            migrationBuilder.AlterColumn<int>(
                name: "IdPessoa",
                table: "SaldoPessoa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdConta",
                table: "SaldoPessoa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SaldoPessoa_Conta_IdConta",
                table: "SaldoPessoa",
                column: "IdConta",
                principalTable: "Conta",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaldoPessoa_Pessoa_IdPessoa",
                table: "SaldoPessoa",
                column: "IdPessoa",
                principalTable: "Pessoa",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
