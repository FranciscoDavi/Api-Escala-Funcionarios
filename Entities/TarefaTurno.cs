namespace Api.Entities
{
    public class TarefaTurno
    {
        public int Id { get; set; }
        public int TarefaID { get; set; }
        public Tarefa Tarefa{ get; set; }
        public int TurnoID { get; set; }
        public Turno Turno { get; set; }
    }
}