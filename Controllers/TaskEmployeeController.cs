using Api.DTOS;
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskEmployeeController : ControllerBase
    {
        private readonly TaskEmployeeService _service;

        public TaskEmployeeController (TaskEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult PostTaskEmployee(TaskEmployee _taskEmployee)
        {
            try{
                TaskEmployeeDTO taskEmployee = _service.AssociateTaskEmployee(_taskEmployee);

                if(taskEmployee == null)
                    return BadRequest();
            

                return Ok(taskEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
           
        }        


    }



}