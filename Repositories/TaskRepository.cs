using Api.Data;
using Api.Entities;

namespace Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly StaffScheduleDBContext _context;

        public TaskRepository(StaffScheduleDBContext context)
        {
            _context = context;
        }

        public Tasks Create(Tasks task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return task;
        }

        public List<Tasks> GetAll()
        {
           return  _context.Tasks.ToList();
        }

        public Tasks GetById(int id)
        {
            return _context.Tasks.Find(id);
        }
        public Tasks Update(int Id, Tasks task)
        {
            Tasks dbTask = _context.Tasks.Find(Id);   

            dbTask.Name = task.Name;
            dbTask.Description = task.Description;

            _context.Tasks.Update(dbTask);
            _context.SaveChanges();

            return task;
        }

        public void Delete(Tasks tarefa)
        {
            _context.Tasks.Remove(tarefa);
            _context.SaveChanges();
        }
    }
}