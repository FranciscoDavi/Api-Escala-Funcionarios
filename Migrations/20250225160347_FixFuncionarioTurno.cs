using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FixFuncionarioTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FuncionarioTurnos",
                table: "FuncionarioTurnos");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FuncionarioTurnos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuncionarioTurnos",
                table: "FuncionarioTurnos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioTurnos_FuncionarioID",
                table: "FuncionarioTurnos",
                column: "FuncionarioID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FuncionarioTurnos",
                table: "FuncionarioTurnos");

            migrationBuilder.DropIndex(
                name: "IX_FuncionarioTurnos_FuncionarioID",
                table: "FuncionarioTurnos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FuncionarioTurnos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuncionarioTurnos",
                table: "FuncionarioTurnos",
                columns: new[] { "FuncionarioID", "TurnoID" });
        }
    }
}
