using Api.Entities;
using Api.Data;

namespace Api.Repositories
{
    public class ShiftEmployeeRepository : IShiftEmployeeRepository
    {
        private readonly EscalaDBContext _context;

        public ShiftEmployeeRepository(EscalaDBContext context){
            _context = context;
        }

        public Turno GetShiftById(int id)
        {
            return _context.Turnos.Find(id);
        }

        public Funcionario GetEmployeeById(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public void Associate(FuncionarioTurno shiftEmployee)
        {
            _context.FuncionarioTurnos.Add(shiftEmployee);
            _context.SaveChanges();
        }

    }

}