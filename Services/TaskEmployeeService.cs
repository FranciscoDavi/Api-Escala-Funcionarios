using Api.DTOS;
using Api.Entities;
using Api.Repositories;

namespace  Api.Services
{
    public class TaskEmployeeService
    {
        private readonly ITaskEmployeeRepository _repository;

        public TaskEmployeeService(ITaskEmployeeRepository repository)
        {
            _repository = repository;
        }

        public TarefaFuncionarioDTO AssociateTaskEmployee(TarefaFuncionario taskEmployee)
        {
            Tarefa task = _repository.GetTaskById(taskEmployee.TarefaID);
            Funcionario employee = _repository.GetEmployeeById(taskEmployee.FuncionarioID);

            if(task == null || employee == null)
            {
                return null;
            }

            _repository.Associate(taskEmployee);       

            TarefaFuncionarioDTO taskEmployeeDTO = new TarefaFuncionarioDTO{TarefaId =taskEmployee.TarefaID, FuncionarioId = taskEmployee.FuncionarioID}; 

            return taskEmployeeDTO;
        }

    }
}