using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly EscalaDBContext _context;

        public TaskRepository(EscalaDBContext context)
        {
            _context = context;
        }

        public Tarefa Create(Tarefa task)
        {
            _context.Tarefas.Add(task);
            _context.SaveChanges();
            return task;
        }

        public List<Tarefa> GetAll()
        {
           return  _context.Tarefas.ToList();
        }

        public Tarefa GetById(int id)
        {
            return _context.Tarefas.Find(id);
        }
        public Tarefa Update(int Id, Tarefa task)
        {
            Tarefa dbTask = _context.Tarefas.Find(Id);   

            dbTask.Name = task.Name;
            dbTask.Descricao = task.Descricao;

            _context.Tarefas.Update(dbTask);
            _context.SaveChanges();

            return task;
        }

        public void Delete(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
        }
    }
}