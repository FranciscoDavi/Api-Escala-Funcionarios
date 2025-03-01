
using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EscalaDBContext _context;

        public EmployeeRepository(EscalaDBContext context)
        {
            _context = context;
        }

        public List<Funcionario> GetAll()
        {
            return _context.Funcionarios.ToList();
        }

        public Funcionario GetById(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public Funcionario Create(Funcionario employee)
        {
            _context.Funcionarios.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Funcionario Update(Funcionario employee)
        {
            _context.Funcionarios.Update(employee);
            _context.SaveChanges();
            return employee;
        }
        
        public void Delete(Funcionario employee)
        {
            _context.Funcionarios.Remove(employee);
            _context.SaveChanges();
        }
    }
}