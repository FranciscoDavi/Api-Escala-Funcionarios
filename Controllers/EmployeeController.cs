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
            Funcionario employee = _service.GetEmployeeById(id);
            return Ok(employee);

        }


        [HttpPost]
        public IActionResult PostEmployee(Funcionario employee)
        {
            try
            {
                EmployeeDTO newEmployee = _service.CreateEmployee(employee);
                return Ok(newEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult PutEmployee(int id, Funcionario employee)
        {
            try
            {
                Funcionario updatedEmployee = _service.UpdateEmployee(id, employee);

                if (updatedEmployee == null) 
                {
                    return NotFound();
                }

                return Ok(updatedEmployee);
            }
            catch(Exception ex)
            {
                return  BadRequest(ex.Message);
            }
            
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
           try
           {
                Funcionario employee = _service.DeleteEmployee(id);

                if (employee == null)
                {
                    return NotFound();
                }

                return NoContent();
           }    
           catch (Exception ex)
           {
                return BadRequest(ex.Message);
           }
        }
    }
}