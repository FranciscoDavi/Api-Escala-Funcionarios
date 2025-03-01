
namespace Api.DTOS
{
    public class ShiftDTO
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora_Inicio { get; set; }   
        public DateTime Hora_Termino {get; set; }

        /*
        public List<string> Funcionarios { get; set;} = new();
        public List<string> Tarefas { get; set;} = new();
        */
    }
}