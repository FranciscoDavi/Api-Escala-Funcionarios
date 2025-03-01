
using Api.Entities;

namespace Api.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Funcionario> GetAll();
        public Funcionario GetById(int id);
        public Funcionario Create(Funcionario funcionario);
        public Funcionario Update(Funcionario funcionario);
        public void Delete(Funcionario funcionario);
    }
}