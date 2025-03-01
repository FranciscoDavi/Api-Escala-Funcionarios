using Api.Data;
using Api.Entities;
using Api.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioTurnoController : ControllerBase
    {
        private readonly EscalaDBContext _context;

        public FuncionarioTurnoController(EscalaDBContext context){
            _context = context;
        }
        
        [HttpPost]
        public IActionResult AssociarFuncionarioTurno(FuncionarioTurnoDTO dto)
        {
            var funcionarioTurno = new FuncionarioTurno{
                FuncionarioID = dto.FuncionarioId,
                TurnoID = dto.TurnoId,
            };

            _context.FuncionarioTurnos.Add(funcionarioTurno);
            _context.SaveChanges();

            return Ok(funcionarioTurno);
          
        }
    }
}