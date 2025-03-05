
using Api.Entities;

namespace Api.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public Employee Create(Employee funcionario);
        public Employee Update(Employee funcionario);
        public void Delete(Employee funcionario);
    }
}