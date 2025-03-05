using Api.Entities;
using Api.Data;

namespace Api.Repositories
{
    public class ShiftEmployeeRepository : IShiftEmployeeRepository
    {
        private readonly StaffScheduleDBContext _context;

        public ShiftEmployeeRepository(StaffScheduleDBContext context){
            _context = context;
        }

        public Shift GetShiftById(int id)
        {
            return _context.Shifts.Find(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Associate(ShiftEmployee shiftEmployee)
        {
            _context.ShiftEmployees.Add(shiftEmployee);
            _context.SaveChanges();
        }

    }

}