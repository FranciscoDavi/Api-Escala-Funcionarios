using Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.DTOS;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service){
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            IEnumerable<EmployeeDTO> employees = _service.GetAllEmployees();
            return Ok(employees); 
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            EmployeeDTO employee = _service.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult PostEmployee(EmployeeDTO employee)
        {   
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Employee newEmployee = _service.CreateEmployee(employee);
            return Ok(newEmployee);    
        }

        [HttpPut("{id}")]
        public IActionResult PutEmployee(int id, EmployeeDTO employee)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Employee updatedEmployee = _service.UpdateEmployee(id, employee);

            if (updatedEmployee == null) 
            {
                return NotFound();
            }

            return Ok(updatedEmployee);   
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
           Employee employee = _service.DeleteEmployee(id);

            if (employee == null)
                return NotFound();
                
            return NoContent();
            
        }
    }
}