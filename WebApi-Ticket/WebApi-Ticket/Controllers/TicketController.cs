using Microsoft.AspNetCore.Mvc;
using WebApi_Ticket.Business;
using WebApi_Ticket.Models;

namespace WebApi_Ticket.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketBusiness _ticketBusiness;

        public TicketController(ITicketBusiness ticketBusiness)
        {
            _ticketBusiness = ticketBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ticketBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var ticket = _ticketBusiness.FindById(id);
            if (ticket == null) return NotFound();
            return Ok(ticket);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ticket ticket)
        {
            if(ModelState.IsValid)
            {
                return Ok(_ticketBusiness.Create(ticket));
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                return Ok(_ticketBusiness.Update(ticket));
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _ticketBusiness.Delete(id);
            return NoContent();
        }
    }
}
