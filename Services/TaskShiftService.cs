
using Api.Entities;
using Api.DTOS;
using Api.Repositories;

namespace Api.Services
{
    public class TaskShiftService
    {
        private readonly ITaskShiftRepository _repository;

        public TaskShiftService(ITaskShiftRepository repository)
        {
            _repository = repository;
        }

        public TaskShiftDTO AssociateTaskShift(TarefaTurno taskShift)
        {
            Tarefa task = _repository.GetTaskById(taskShift.TarefaID);
            Turno shift = _repository.GetShiftById(taskShift.TurnoID);

            if(task == null || shift == null)
            {
                return null;
            }

            _repository.Associate(taskShift);

            TaskShiftDTO taskShiftDTO = new TaskShiftDTO{TarefaID = taskShift.TarefaID, TurnoID = taskShift.TurnoID}; 

            return taskShiftDTO;
        }
    }
}