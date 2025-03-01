
using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly EscalaDBContext _context;

        public ShiftRepository(EscalaDBContext context)
        {
            _context = context;
        }

        public List<Turno> GetAll()
        {
            return _context.Turnos.ToList();    
        }

        public Turno GetById(int id)
        {
            return _context.Turnos.Find(id);
        }
        
        public Turno Create(Turno shift)
        {
            _context.Turnos.Add(shift);
            _context.SaveChanges();
            return shift;
        }

        public void Update(Turno shift)
        {
            _context.Turnos.Update(shift);
            _context.SaveChanges();
          
        }

        public void Delete(Turno shift)
        {
            _context.Turnos.Remove(shift);
            _context.SaveChanges();
        }
    }
}