
namespace Api.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }

        public List<TarefaFuncionario> TarefasFuncionarios {get; set; } = new ();
        public List<TarefaTurno> TarefasTurnos {get; set;} = new ();

    }

}