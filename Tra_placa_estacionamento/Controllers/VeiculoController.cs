using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Tra_placa_estacionamento.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private EstacionamentoDbContext _context;
    public VeiculoController(EstacionamentoDbContext context)
    {
        _context = context;
    }
    
    [HttpGet()]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Veiculo>>> Listar()
    {
        if (_context.veiculo is null) return NotFound();
        return await _context.veiculo.ToListAsync();
    }
    
    [HttpGet()]
    [Route("buscar/{placa}")]
    public async Task<ActionResult<Veiculo>> Buscar([FromRoute]string placa)
    {
        if (_context.veiculo is null) return NotFound();
        var veiculo = await _context.veiculo.FindAsync(placa);
        return veiculo;
    }

    [HttpPost()]
    [Route("cadastrar")]
    public async Task<IActionResult> Cadastrar(Veiculo veiculo)
    {
        await _context.AddAsync(veiculo);
        await _context.SaveChangesAsync();
        return Created("", veiculo);
    }

    [HttpPut]
    [Route("alterar")]
    public async Task<IActionResult> Alterar(Veiculo veiculo)
    {
        _context.veiculo.Update(veiculo);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("excluir/{placa}")]
     public async Task<IActionResult> excluir(string placa)
     {
        var veiculo = await _context.veiculo.FindAsync(placa);
        if (_context.veiculo is null) return NotFound();
        _context.veiculo.Remove(veiculo);
        await _context.SaveChangesAsync();
        return Ok();
     }

     [HttpPatch]
     [Route("modificardescricao/{placa}")]
     public async Task<IActionResult> ModificarDescricao(string placa, [FromForm] int Id)
     {
        var veiculo = await _context.veiculo.FindAsync(placa);
        if (_context.veiculo is null) return NotFound();
        veiculo.Id = Id;
        await _context.SaveChangesAsync();
        return Ok();
     }
}