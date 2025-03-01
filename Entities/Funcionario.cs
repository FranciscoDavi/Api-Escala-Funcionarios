
namespace Api.Entities 
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<FuncionarioTurno> FuncionariosTurnos {get; set; } = new();
        public List<TarefaFuncionario> TarefasFuncionarios {get; set; } = new();
    }
}