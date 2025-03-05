
using Api.Entities;
using Api.DTOS;
using Api.Repositories;

namespace Api.Services
{
    public class ShiftTaskService
    {
        private readonly IShiftTaskRepository _repository;

        public ShiftTaskService(IShiftTaskRepository repository)
        {
            _repository = repository;
        }

        public ShiftTaskDTO AssociateShiftTask(ShiftTaskDTO shiftTaskDTO)
        {
            ShiftTask shiftTask = new ShiftTask{ShiftId = shiftTaskDTO.ShiftId, TaskId = shiftTaskDTO.TaskId};

            Tasks task = _repository.GetTaskById(shiftTask.TaskId);
            Shift shift = _repository.GetShiftById(shiftTask.ShiftId);

            if(task == null || shift == null)
                return null;
    
            _repository.Associate(shiftTask);

            return shiftTaskDTO;
        }
    }
}