using Api.Data;
using Api.Entities;

namespace Api.Repositories 
{
    public class TaskEmployeeRepository : ITaskEmployeeRepository
    {
        private readonly StaffScheduleDBContext _context;

        public TaskEmployeeRepository(StaffScheduleDBContext context)
        { 
            _context = context;
        }

        public Tasks GetTaskById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Associate(TaskEmployee taskEmployee)
        {
            _context.TaskEmployees.Add(taskEmployee);
            _context.SaveChanges();
        }

    }

}