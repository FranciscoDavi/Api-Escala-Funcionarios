using Api.DTOS;
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShiftEmployeeController : ControllerBase
    {
        private ShiftEmployeeService _service;

        public ShiftEmployeeController(ShiftEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult PostShiftEmployee(ShiftEmployee shiftEmployee)
        {
            ShiftEmployeeDTO newShiftEmployee = _service.AssociateShiftEmployee(shiftEmployee);

            if(newShiftEmployee == null)
            {
                return NotFound();
            }
            
            return Ok(newShiftEmployee);      
        }
    }
}