
using Api.Data;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly StaffScheduleDBContext _context;

        public ShiftRepository(StaffScheduleDBContext context)
        {
            _context = context;
        }

        public List<Shift> GetAll()
        {
            return  _context.Shifts.Include(se => se.ShiftEmployees).ThenInclude(e => e.Employee)
                    .Include(st => st.ShiftTasks).ThenInclude(t => t.Task).ToList();    
        }

        public Shift GetById(int id)
        {
            return _context.Shifts.Include(se => se.ShiftEmployees).ThenInclude(e => e.Employee)
                    .Include(st => st.ShiftTasks).ThenInclude(t => t.Task).Where(se => se.Id == id).FirstOrDefault();   
        }
        
        public Shift Create(Shift shift)
        {
            _context.Shifts.Add(shift);
            _context.SaveChanges();
            return shift;
        }

        public void Update(Shift shift)
        {
            _context.Shifts.Update(shift);
            _context.SaveChanges();
          
        }

        public void Delete(Shift shift)
        {
            _context.Shifts.Remove(shift);
            _context.SaveChanges();
        }
    }
}