using Api.Entities;
using Api.Repositories;

namespace  Api.Services
{
    public class TaskService 
    {
        private readonly ITaskRepository _repository;

        public TaskService (ITaskRepository repository)
        {
            _repository = repository;
        }

        public Tasks CreateTask(Tasks task)
        {
            return _repository.Create(task);
        }

        public List<Tasks> GetAllTasks()
        {
            return _repository.GetAll();
        }

        public Tasks GetOneTask(int id)
        {
            Tasks task = _repository.GetById(id);
            return task; 
        }

        public Tasks UpdateTask(int id, Tasks task)
        {   
            Tasks IfExistTask = _repository.GetById(id);

            if (IfExistTask == null) return null;

            Tasks updatedTask = _repository.Update(id, task);
                
            return updatedTask;
        }

        public Tasks DeleteTask(int id)
        {
            Tasks task = _repository.GetById(id);
            
            if(task == null) return null;

            _repository.Delete(task);

            return task;
        }

    }
}