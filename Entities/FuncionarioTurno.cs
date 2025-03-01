
namespace Api.Entities
{
    public class FuncionarioTurno
    {
        public int Id { get; set; }
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }
        public int TurnoID { get; set; }
        public Turno Turno { get; set; }
    }
}