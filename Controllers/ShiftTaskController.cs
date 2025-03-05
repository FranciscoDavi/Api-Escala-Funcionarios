using Api.DTOS;
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShiftTaskController: ControllerBase
    {
        private readonly ShiftTaskService _service;
        public ShiftTaskController(ShiftTaskService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult PostShiftTask(ShiftTaskDTO shiftTaskDTO)
        {
            if(!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            ShiftTaskDTO taskShift = _service.AssociateShiftTask(shiftTaskDTO);

            if(taskShift == null)
            {
                return NotFound();
            }

            return Ok(taskShift);     
        }
    }
}