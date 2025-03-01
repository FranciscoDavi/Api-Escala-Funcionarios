
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _service;

        public TaskController (TaskService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetTask()
        {
            List<Tarefa> tasks = _service.GetAllTasks();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetOneTask(int id)
        {
            Tarefa tasks = _service.GetOneTask(id);
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult PostTask (Tarefa task)
        {
            if(task == null) return NotFound();

            Tarefa newPost = _service.CreateTask(task);

            return Ok(newPost);
        }

        [HttpPut("{id}")]
        public IActionResult PutTask (int id, Tarefa task)
        {
            Tarefa updatedTask = _service.UpdateTask(id, task);

            if(updatedTask == null)
                return NotFound();

            return Ok(updatedTask);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask (int id)
        {
            try{
                Tarefa deletedTask = _service.DeleteTask(id);

                if(deletedTask == null) 
                    return NotFound();

                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }     
          
        }
    }
}