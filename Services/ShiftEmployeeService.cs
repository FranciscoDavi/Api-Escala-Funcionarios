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

        public FuncionarioTurnoDTO AssociateShiftEmployee(FuncionarioTurno shiftEmployee)
        {
            Turno shift  = _repository.GetShiftById(shiftEmployee.TurnoID);
            Funcionario employee = _repository.GetEmployeeById(shiftEmployee.FuncionarioID);

            if (shift == null || employee == null)
            {
                return null;
            }
            
            _repository.Associate(shiftEmployee);

            return new FuncionarioTurnoDTO{TurnoId = shiftEmployee.TurnoID, FuncionarioId = shiftEmployee.FuncionarioID}; 
        }
    }
}