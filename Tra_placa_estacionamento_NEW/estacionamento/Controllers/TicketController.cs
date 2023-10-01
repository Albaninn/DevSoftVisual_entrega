
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Tra_placa_estacionamento.Controllers;



    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {

            //--------------------------------------------------------------------//

            //injeção de dependencia para a acesso ao banco de dados sqlite;

            private EstacionamentoDbContext _context;
            public TicketController(EstacionamentoDbContext context)
            {
                _context = context;
            }

            //--------------------------------------------------------------------//




            [HttpGet()]
            [Route("listarticket")]
            public async Task<ActionResult<IEnumerable<Ticket>>> GetListarAsync()
            {
                if (_context.ticket is null) return NotFound();
                return await _context.ticket.ToListAsync();
            }


            //--------------------------------------------------------------------//

            [HttpGet()]
            [Route("buscar/{COD}")]
            public async Task<ActionResult<Ticket>> Buscar([FromRoute] int codTicket)
            {
                if (_context.ticket is null) return NotFound();
                var ticket = await _context.ticket.FindAsync(codTicket);
                return ticket;
            }


            //--------------------------------------------------------------------//

            [HttpPost()]
            [Route("inserir")]
            public async Task<ActionResult<Ticket>> Inserir([FromBody] Ticket ticket)
            {
                _context.ticket.Add(ticket);
                await _context.SaveChangesAsync();
                return ticket;
            }

            //--------------------------------------------------------------------//


            [HttpPut]
            [Route("alterar")]
            public async Task<IActionResult> Alterar(Ticket ticket)
            {
                _context.ticket.Update(ticket);
                await _context.SaveChangesAsync();
                return Ok();
            }

            //--------------------------------------------------------------------//

            [HttpDelete]
            [Route("excluir/{COD}")]
            public async Task<IActionResult> Excluir([FromRoute] string codTicket)
            {
                var ticket = await _context.ticket.FindAsync(codTicket);
                if (ticket is null) return NotFound();
                _context.ticket.Remove(ticket);
                await _context.SaveChangesAsync();
                return Ok();
            }

            //--------------------------------------------------------------------//





            



            
        
    }

