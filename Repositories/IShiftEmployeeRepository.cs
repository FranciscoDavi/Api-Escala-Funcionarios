using Api.Entities;

namespace Api.Repositories
{
    public interface IShiftEmployeeRepository
    {
        public Shift GetShiftById(int id);
        
        public Employee GetEmployeeById(int id);

        public void Associate(ShiftEmployee shiftEmployee);
    }


}