using Api.Data;
using Api.Entities;

namespace Api.Repositories 
{
    public class TaskEmployeeRepository : ITaskEmployeeRepository
    {
        private readonly EscalaDBContext _context;

        public TaskEmployeeRepository(EscalaDBContext context)
        { 
            _context = context;
        }

        public Tarefa GetTaskById(int id)
        {
            return _context.Tarefas.Find(id);
        }

        public Funcionario GetEmployeeById(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public void Associate(TarefaFuncionario taskEmployee)
        {
            _context.TarefasFuncionarios.Add(taskEmployee);
            _context.SaveChanges();
        }

    }

}