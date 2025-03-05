using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class ShiftTaskRepository : IShiftTaskRepository
    {
        private StaffScheduleDBContext _context;

        public ShiftTaskRepository (StaffScheduleDBContext context)
        {
            _context = context;
        }

        public Tasks GetTaskById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public Shift GetShiftById(int id)
        {
            return _context.Shifts.Find(id);
        }

        public void Associate(ShiftTask shiftTask)
        {
            _context.ShiftTasks.Add(shiftTask);      
            _context.SaveChanges();
        }
    }

}