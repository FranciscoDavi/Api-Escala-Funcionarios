using Api.Entities;

namespace Api.Repositories
{
    public interface ITaskShiftRepository
    {
        public Tarefa GetTaskById(int id);
        public Turno GetShiftById(int id);
        public void Associate(TarefaTurno taskShift);

    }
}