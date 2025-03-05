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
            List<Employee> employees = _repository.GetAll();
    
            return employees.Select(e => new EmployeeDTO {
                Id = e.Id, 
                Name = e.Name, 
                Surname = e.Surname, 
                Email = e.Email, 
                Phone = e.Phone,
                Shifts = e.ShiftEmployees.Select(se => new ShiftDTO{
                    Id = se.Shift.Id,
                    Period = se.Shift.Period,
                    Start_Time = se.Shift.Start_Time,
                    End_Time = se.Shift.End_Time
                }).ToList(),
                Tasks = e.TaskEmployees.Select(te => new TaskDTO{
                    Id = te.Task.Id,
                    Name = te.Task.Name,
                    Date = te.Task.Date
                }).ToList(),
            });
        }

        public EmployeeDTO GetEmployeeById(int id)
        {

            Employee employee = _repository.GetById(id);

            return new EmployeeDTO{
                Id = employee.Id, 
                Name = employee.Name,
                Surname = employee.Surname, 
                Email = employee.Email, 
                Phone = employee.Phone,
                Shifts = employee.ShiftEmployees.Select(se => new ShiftDTO{
                    Id = se.Shift.Id,
                    Period = se.Shift.Period,
                    Start_Time = se.Shift.Start_Time,
                    End_Time = se.Shift.End_Time
                }).ToList(),
                Tasks = employee.TaskEmployees.Select(te => new TaskDTO{
                    Id = te.Task.Id,
                    Name = te.Task.Name,
                    Date = te.Task.Date
                }).ToList(),
            };
        }   
    
        public Employee CreateEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee{
                Id = employeeDTO.Id,
                Name = employeeDTO.Name,
                Surname = employeeDTO.Surname,
                Email = employeeDTO.Email,
                Phone = employeeDTO.Phone
            };
            
            return _repository.Create(employee);
        
        }

        public Employee UpdateEmployee(int id, EmployeeDTO employeeDTO)
        {

            Employee databaseEmployee = _repository.GetById(id);

            if (databaseEmployee == null)
            {
                return null;
            }

            databaseEmployee.Name = employeeDTO.Name;
            databaseEmployee.Surname = employeeDTO.Surname;
            databaseEmployee.Email = employeeDTO.Email;
            databaseEmployee.Phone = employeeDTO.Phone;

            Employee updatedEmployee = _repository.Update(databaseEmployee);
            
            return updatedEmployee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = _repository.GetById(id);

            if(employee == null)
            {
                return null;
            }

            _repository.Delete(employee);
            return employee;
        }
    }

}