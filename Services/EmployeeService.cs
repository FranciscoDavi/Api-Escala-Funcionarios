using Api.DTOS;
using Api.Entities;
using Api.Repositories;

namespace Api.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService (IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees (){
            List<Funcionario> employees = _repository.GetAll();
            return employees.Select(e => new EmployeeDTO {Id = e.Id, Nome = e.Nome});
        }

        public Funcionario GetEmployeeById(int id)
        {
            return _repository.GetById(id);
        }   
    
        public EmployeeDTO CreateEmployee(Funcionario _employee)
        {
            Funcionario employee = _repository.Create( _employee);

            EmployeeDTO employeeDTO = new EmployeeDTO {Id = employee.Id, Nome = employee.Nome};

            return employeeDTO;
        }

        public Funcionario UpdateEmployee(int id, Funcionario employee)
        {
            Funcionario dbEmployee = _repository.GetById(id);

            if (dbEmployee == null)
            {
                return null;
            }

            dbEmployee.Nome = employee.Nome;

            Funcionario updatedEmployee = _repository.Update(dbEmployee);
            return updatedEmployee;
        }

        public Funcionario DeleteEmployee(int id)
        {
            Funcionario employee = _repository.GetById(id);

            if(employee == null)
            {
                return null;
            }

            _repository.Delete(employee);
            return employee;
        }
    }

}