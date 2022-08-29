using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudEscola.Migrations
{
    public partial class CriandoVinculoDoAlunoComTurma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Escola",
                newName: "Nome_Escola");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Escola",
                newName: "Id_Escola");

            migrationBuilder.AlterColumn<int>(
                name: "Idade_Aluno",
                table: "Aluno",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AlunoID",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_AlunoID",
                table: "Aluno",
                column: "AlunoID");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Aluno_AlunoID",
                table: "Aluno",
                column: "AlunoID",
                principalTable: "Aluno",
                principalColumn: "Id_Aluno");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id_Turma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Aluno_AlunoID",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_AlunoID",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "AlunoID",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "Nome_Escola",
                table: "Escola",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Id_Escola",
                table: "Escola",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Idade_Aluno",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
