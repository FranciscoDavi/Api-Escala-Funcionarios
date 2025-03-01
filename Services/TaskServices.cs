using Api.Entities;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace  Api.Services
{
    public class TaskService 
    {
        private readonly ITaskRepository _repository;

        public TaskService (ITaskRepository repository)
        {
            _repository = repository;
        }

        public Tarefa CreateTask(Tarefa task)
        {
            return _repository.Create(task);
        }

        public List<Tarefa> GetAllTasks()
        {
            return _repository.GetAll();
        }

        public Tarefa GetOneTask(int id)
        {
            Tarefa task = _repository.GetById(id);
            return task; 
        }

        public Tarefa UpdateTask(int id, Tarefa task)
        {   
            Tarefa IfExistTask = _repository.GetById(id);

            if (IfExistTask == null) return null;

            Tarefa updatedTask = _repository.Update(id, task);
                
            return updatedTask;
        }

        public Tarefa DeleteTask(int id)
        {
            Tarefa task = _repository.GetById(id);
            
            if(task == null) return null;

            _repository.Delete(task);

            return task;
        }

    }
}