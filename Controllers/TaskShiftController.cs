using Api.DTOS;
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskShiftController: ControllerBase
    {
        private readonly TaskShiftService _service;
        public TaskShiftController(TaskShiftService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult PostTaskShift(TarefaTurno _taskShift)
        {
            try{
                TaskShiftDTO taskShift = _service.AssociateTaskShift(_taskShift);

                if(taskShift == null)
                    return NotFound();

                 return Ok(taskShift);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }
    }
}