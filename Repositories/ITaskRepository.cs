using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Repositories
{
    public interface ITaskRepository
    {
        public Tarefa Create(Tarefa task);
        public List<Tarefa> GetAll();
        public Tarefa GetById(int id);
        public Tarefa Update(int Id, Tarefa task);
        public void Delete(Tarefa tarefa);
    }

}