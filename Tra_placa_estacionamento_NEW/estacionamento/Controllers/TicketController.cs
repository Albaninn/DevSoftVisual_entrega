﻿
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
            [Route("buscar/{Placa}")]
            public async Task<ActionResult<Ticket>> Buscar([FromRoute] String placa)
            {
                if (_context.ticket is null) return NotFound();
                var ticket = await _context.ticket.FirstOrDefaultAsync(x => x.Veiculo.Placa ==placa );
                return ticket;
            }


            //--------------------------------------------------------------------//

            [HttpPost()]
            [Route("inserir")]
            public async Task<ActionResult<Ticket>> Inserir([FromBody] Ticket novaentrada)
            {
                if (novaentrada.Veiculo.Descricao.Contains("XYZ Widget"))
                {
                return BadRequest();
                }

            _context.ticket.Add(novaentrada);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Buscar), new { id = novaentrada.Id }, novaentrada);
            }

            //--------------------------------------------------------------------//


            [HttpPut]
            [Route("alterar")]
            public async Task<IActionResult> Alterar(Ticket inputticket)
            {
                //var novo = new Ticket(id, codticket, true);

                _context.ticket.Update(inputticket);
                await _context.SaveChangesAsync();
                return Ok();
            }

            //--------------------------------------------------------------------//

            [HttpDelete]
            [Route("excluir/{COD}")]
            public async Task<IActionResult> Excluir([FromRoute] int codTicket)
            {
                var ticket = await _context.ticket.FindAsync(codTicket);
                if (ticket is null) return NotFound();
                _context.ticket.Remove(ticket);
                await _context.SaveChangesAsync();
                return Ok();
            }

            //--------------------------------------------------------------------//





            



            
        
    }

