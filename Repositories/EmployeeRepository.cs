
using Api.Data;
using Api.Entities;
using Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly StaffScheduleDBContext _context;

        public EmployeeRepository(StaffScheduleDBContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.Include(e => e.ShiftEmployees).ThenInclude(es => es.Shift)
                .Include(te => te.TaskEmployees).ThenInclude(t => t.Task).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Include(e => e.ShiftEmployees).ThenInclude(es => es.Shift)
                .Include(te => te.TaskEmployees).ThenInclude(t => t.Task).Where(e=> e.Id == id).FirstOrDefault();
        }

        public Employee Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }
        
        public void Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}