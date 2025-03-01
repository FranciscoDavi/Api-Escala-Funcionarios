using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class TarefasFuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarefaFuncionario_Funcionarios_FuncionarioID",
                table: "TarefaFuncionario");

            migrationBuilder.DropForeignKey(
                name: "FK_TarefaFuncionario_Tarefa_TarefaID",
                table: "TarefaFuncionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TarefaFuncionario",
                table: "TarefaFuncionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa");

            migrationBuilder.RenameTable(
                name: "TarefaFuncionario",
                newName: "TarefasFuncionarios");

            migrationBuilder.RenameTable(
                name: "Tarefa",
                newName: "Tarefas");

            migrationBuilder.RenameIndex(
                name: "IX_TarefaFuncionario_TarefaID",
                table: "TarefasFuncionarios",
                newName: "IX_TarefasFuncionarios_TarefaID");

            migrationBuilder.RenameIndex(
                name: "IX_TarefaFuncionario_FuncionarioID",
                table: "TarefasFuncionarios",
                newName: "IX_TarefasFuncionarios_FuncionarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TarefasFuncionarios",
                table: "TarefasFuncionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TarefasFuncionarios_Funcionarios_FuncionarioID",
                table: "TarefasFuncionarios",
                column: "FuncionarioID",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TarefasFuncionarios_Tarefas_TarefaID",
                table: "TarefasFuncionarios",
                column: "TarefaID",
                principalTable: "Tarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarefasFuncionarios_Funcionarios_FuncionarioID",
                table: "TarefasFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TarefasFuncionarios_Tarefas_TarefaID",
                table: "TarefasFuncionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TarefasFuncionarios",
                table: "TarefasFuncionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "TarefasFuncionarios",
                newName: "TarefaFuncionario");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefa");

            migrationBuilder.RenameIndex(
                name: "IX_TarefasFuncionarios_TarefaID",
                table: "TarefaFuncionario",
                newName: "IX_TarefaFuncionario_TarefaID");

            migrationBuilder.RenameIndex(
                name: "IX_TarefasFuncionarios_FuncionarioID",
                table: "TarefaFuncionario",
                newName: "IX_TarefaFuncionario_FuncionarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TarefaFuncionario",
                table: "TarefaFuncionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TarefaFuncionario_Funcionarios_FuncionarioID",
                table: "TarefaFuncionario",
                column: "FuncionarioID",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TarefaFuncionario_Tarefa_TarefaID",
                table: "TarefaFuncionario",
                column: "TarefaID",
                principalTable: "Tarefa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
