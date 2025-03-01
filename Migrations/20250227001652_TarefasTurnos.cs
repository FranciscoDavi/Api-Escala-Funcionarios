using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class TarefasTurnos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarefasTurnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarefaID = table.Column<int>(type: "int", nullable: false),
                    TurnoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefasTurnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarefasTurnos_Tarefas_TarefaID",
                        column: x => x.TarefaID,
                        principalTable: "Tarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TarefasTurnos_Turnos_TurnoID",
                        column: x => x.TurnoID,
                        principalTable: "Turnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TarefasTurnos_TarefaID",
                table: "TarefasTurnos",
                column: "TarefaID");

            migrationBuilder.CreateIndex(
                name: "IX_TarefasTurnos_TurnoID",
                table: "TarefasTurnos",
                column: "TurnoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarefasTurnos");
        }
    }
}
