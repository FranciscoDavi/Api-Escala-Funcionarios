

namespace Api.Entities
{
    public class Turno
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Termino { get; set; }
        public List<FuncionarioTurno> FuncionariosTurnos {get; set; } = new ();
         public List<TarefaTurno> TarefasTurnos {get; set; } = new ();
    }
}