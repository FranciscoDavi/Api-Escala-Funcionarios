using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Repositories
{
    public interface ITaskRepository
    {
        public Tasks Create(Tasks task);
        public List<Tasks> GetAll();
        public Tasks GetById(int id);
        public Tasks Update(int Id, Tasks task);
        public void Delete(Tasks tarefa);
    }

}