using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoTarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarefas",
                table: "Turnos");

            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarefaFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarefaID = table.Column<int>(type: "int", nullable: false),
                    FuncionarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefaFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarefaFuncionario_Funcionarios_FuncionarioID",
                        column: x => x.FuncionarioID,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TarefaFuncionario_Tarefa_TarefaID",
                        column: x => x.TarefaID,
                        principalTable: "Tarefa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TarefaFuncionario_FuncionarioID",
                table: "TarefaFuncionario",
                column: "FuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_TarefaFuncionario_TarefaID",
                table: "TarefaFuncionario",
                column: "TarefaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarefaFuncionario");

            migrationBuilder.DropTable(
                name: "Tarefa");

            migrationBuilder.AddColumn<string>(
                name: "Tarefas",
                table: "Turnos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
