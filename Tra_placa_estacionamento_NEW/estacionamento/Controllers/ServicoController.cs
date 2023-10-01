
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Tra_placa_estacionamento.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {

        //--------------------------------------------------------------------//

        //injeção de dependencia para a acesso ao banco de dados sqlite;

        private EstacionamentoDbContext _context;
        public ServicoController(EstacionamentoDbContext context)
        {
            _context = context;
        }

        //--------------------------------------------------------------------//



        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Servico>>> GetListarAsync()

        {
            if (_context.servico is null) return NotFound();
            return await _context.servico.ToListAsync();

        }



        [HttpGet()]
        [Route("buscar/{descricao}")]
        public async Task<ActionResult<Servico>> Buscar([FromRoute] string descricao)
        {
            if (_context.servico is null) return NotFound();
            var servico = await _context.servico.FindAsync(descricao);
            return servico;
        }

        //--------------------------------------------------------------------//


        [HttpPost()]
        [Route("cadastrar")]
        public async Task<IActionResult> Cadastrar(Servico servico)
        {
            await _context.AddAsync(servico);
            await _context.SaveChangesAsync();
            return Created("", servico);
        }

        //--------------------------------------------------------------------//

        [HttpPut]
        [Route("alterar")]
        public async Task<IActionResult> Alterar(Servico servico)
        {
            _context.servico.Update(servico);
            await _context.SaveChangesAsync();
            return Ok();
        }


        //--------------------------------------------------------------------//
        [HttpDelete]
        [Route("excluir/{servico}")]
        public async Task<IActionResult> excluir(int idservico)
        {
            var servico = await _context.servico.FindAsync(idservico);
            if (_context.servico is null) return NotFound();
            _context.servico.Remove(servico);
            await _context.SaveChangesAsync();
            return Ok();
        }


        //--------------------------------------------------------------------//




    }

