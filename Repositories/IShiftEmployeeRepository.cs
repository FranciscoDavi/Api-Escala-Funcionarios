using Api.Entities;

namespace Api.Repositories
{
    public interface IShiftEmployeeRepository
    {
        public Turno GetShiftById(int id);
        
        public Funcionario GetEmployeeById(int id);

        public void Associate(FuncionarioTurno shiftEmployee);
    }


}