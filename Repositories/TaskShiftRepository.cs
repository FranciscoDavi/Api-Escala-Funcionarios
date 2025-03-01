using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class TaskShiftRepository : ITaskShiftRepository
    {
        private EscalaDBContext _context;

        public TaskShiftRepository (EscalaDBContext context)
        {
            _context = context;
        }

        public Tarefa GetTaskById(int id)
        {
            return _context.Tarefas.Find(id);
        }

        public Turno GetShiftById(int id)
        {
            return _context.Turnos.Find(id);
        }

        public void Associate(TarefaTurno taskShift)
        {
            _context.TarefasTurnos.Add(taskShift);
        }



    }

}