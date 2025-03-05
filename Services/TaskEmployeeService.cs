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

        public TaskEmployeeDTO AssociateTaskEmployee(TaskEmployee taskEmployee)
        {
            Tasks task = _repository.GetTaskById(taskEmployee.TaskId);
            Employee employee = _repository.GetEmployeeById(taskEmployee.EmployeeId);

            if(task == null || employee == null)
            {
                return null;
            }

            _repository.Associate(taskEmployee);       

            TaskEmployeeDTO taskEmployeeDTO = new TaskEmployeeDTO{TaskId = taskEmployee.TaskId, EmployeeId = taskEmployee.EmployeeId}; 

            return taskEmployeeDTO;
        }

    }
}