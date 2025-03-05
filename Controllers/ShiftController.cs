using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.DTOS;
using Api.Entities;

namespace Api.Controllers{
    [Route("[controller]")]
    [ApiController]

    public class ShiftController : ControllerBase{
        private readonly ShiftService _service;

        public ShiftController(ShiftService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetShifts()
        {
            IEnumerable<ShiftDTO> shifts = _service.GetAllShifts();
            return Ok(shifts);
        }

        [HttpGet("{id}")]
        public IActionResult GetShift(int id)
        {
            Shift shift = _service.GetShiftById(id);
            
            if(shift == null) 
                return NotFound();

            return Ok(shift);
        }

        [HttpPost]
        public IActionResult PostShift(ShiftDTO shift)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            Shift newShift = _service.CreateShift(shift);
            return Ok(newShift);
        }


        [HttpPut("{id}")]
        public IActionResult PutPost(int id, Shift shift)
        {
            Shift updatedShift = _service.UpdateShift(id, shift);

            if(updatedShift == null)
                return NotFound();

            return Ok(updatedShift);   

        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            Shift deletedShift = _service.DeleteShift(id);

            if(deletedShift == null)
                return NotFound();

            return NoContent(); 

        }
    }

}