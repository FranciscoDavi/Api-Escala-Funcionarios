
using Api.Entities;

namespace Api.Repositories
{
    public interface ITaskEmployeeRepository
    {
        public Tarefa GetTaskById(int id);
        public Funcionario GetEmployeeById(int id);
        public void Associate(TarefaFuncionario taskEmployee);

    }
}