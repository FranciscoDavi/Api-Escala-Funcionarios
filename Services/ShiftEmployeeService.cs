using Api.DTOS;
using Api.Entities;
using Api.Repositories;

namespace Api.Services
{
    public class ShiftEmployeeService
    {
        private readonly IShiftEmployeeRepository _repository;

        public ShiftEmployeeService(IShiftEmployeeRepository repository)
        {
            _repository = repository;
        }

        public ShiftEmployeeDTO AssociateShiftEmployee(ShiftEmployee shiftEmployee)
        {
            Shift shift  = _repository.GetShiftById(shiftEmployee.ShiftId);
            Employee employee = _repository.GetEmployeeById(shiftEmployee.EmployeeId);

            if (shift == null || employee == null)
            {
                return null;
            }
            
            _repository.Associate(shiftEmployee);

            return new ShiftEmployeeDTO{ShiftId = shiftEmployee.ShiftId, EmployeeId = shiftEmployee.EmployeeId}; 
        }
    }
}