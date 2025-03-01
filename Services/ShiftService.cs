using Api.DTOS;
using Api.Entities;
using Api.Repositories;

namespace Api.Services
{
    public class ShiftService
    {
        private readonly IShiftRepository _repository;

        public ShiftService (IShiftRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ShiftDTO> GetAllShifts()
        {
            List<Turno> shifts =  _repository.GetAll();

            return shifts.Select(s => new ShiftDTO{ Id = s.Id, Periodo = s.Periodo,
                     Data = s.Data, Hora_Inicio = s.Hora_Inicio, Hora_Termino = s.Hora_Termino});
        }
        public Turno GetShiftById(int id){
            return _repository.GetById(id);
        }

        public Turno CreateShift(Turno shift)
        {
            return _repository.Create(shift);
        }

        public Turno UpdateShift(int id, Turno shift)
        {
            Turno updatedShift = _repository.GetById(id);

            if(shift == null)
            {
                return null;
            }

            updatedShift.Periodo = shift.Periodo;
            updatedShift.Data = shift.Data;
            updatedShift.Hora_Inicio = shift.Hora_Inicio;
            updatedShift.Hora_Termino = shift.Hora_Termino;

            _repository.Update(updatedShift);

            return shift;
        }

        public Turno DeleteShift(int id)
        {
            Turno shift = _repository.GetById(id);

            if(shift == null)
                return null;

            _repository.Delete(shift);
            return shift;
        }
    }

}