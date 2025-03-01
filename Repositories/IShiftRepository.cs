using Api.Entities;

namespace Api.Repositories
{
    public interface IShiftRepository
    {
        public List<Turno> GetAll();
        public Turno GetById(int id);
        public Turno Create(Turno shift);
        public void Update(Turno shift);
        public void Delete(Turno shift);
    }
}