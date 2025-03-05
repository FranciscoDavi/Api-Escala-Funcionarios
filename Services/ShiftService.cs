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
            List<Shift> shifts =  _repository.GetAll();

            return shifts.Select(s => new ShiftDTO{ 
                Id = s.Id,
                Period = s.Period, 
                Start_Time = s.Start_Time,
                End_Time = s.End_Time,
                Employees = s.ShiftEmployees.Select(e => new EmployeeDTO{
                    Id = e.Employee.Id,
                    Name = e.Employee.Name,
                    Surname = e.Employee.Surname,
                    Email = e.Employee.Email,
                    Phone = e.Employee.Phone,
                }).ToList(),
                Tasks = s.ShiftTasks.Select(t => new TaskDTO{
                    Id = t.Task.Id,
                    Name = t.Task.Name,
                    Description = t.Task.Description,
                    Date  = t.Task.Date,
                }).ToList() 
            });
        }
        public Shift GetShiftById(int id){
            return _repository.GetById(id);
        }

        public Shift CreateShift(ShiftDTO shiftDTO)
        {
            Shift shift = new Shift{
                Id = shiftDTO.Id,
                Period = shiftDTO.Period,
                Start_Time = shiftDTO.Start_Time,
                End_Time = shiftDTO.End_Time,
            };

            return _repository.Create(shift);
        }

        public Shift UpdateShift(int id, Shift shift)
        {
            Shift updatedShift = _repository.GetById(id);

            if(shift == null)
                return null;

            updatedShift.Period = shift.Period;
            updatedShift.Start_Time= shift.Start_Time;
            updatedShift.End_Time = shift.End_Time;

            _repository.Update(updatedShift);

            return shift;
        }

        public Shift DeleteShift(int id)
        {
            Shift shift = _repository.GetById(id);

            if(shift == null)
                return null;

            _repository.Delete(shift);
            return shift;
        }
    }

}