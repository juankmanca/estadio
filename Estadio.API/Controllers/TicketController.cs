using Estadio.API.Data;
using Estadio.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Estadio.API.Controllers
{
    [ApiController]
    [Route("/api/tickets")]
    public class TicketController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketController(DataContext Context)
        {
            _context = Context;
        }

        [HttpGet("Validate/{id}")]
        public IActionResult Validate(int id)
        {
            try
            {
                Ticket? ticket = _context.Ticket.FirstOrDefault(x => x.Id == id);
                if (ticket is null) return BadRequest("Ticket no registrado");
                return Ok(ticket);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateAsync([FromBody] Ticket ticket)
        {
            try
            {
                if (ticket is null) return BadRequest("Ticket no enviado");
                _context.Ticket.Update(ticket);
                int rows = _context.SaveChanges();
                if (rows > 0) return Ok();
                else return BadRequest("Error al registrar el ticket");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
