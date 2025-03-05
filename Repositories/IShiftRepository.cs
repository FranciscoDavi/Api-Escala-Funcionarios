using Api.Entities;

namespace Api.Repositories
{
    public interface IShiftRepository
    {
        public List<Shift> GetAll();
        public Shift GetById(int id);
        public Shift Create(Shift shift);
        public void Update(Shift shift);
        public void Delete(Shift shift);
    }
}