using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private readonly ILogger<VeiculoController> _logger;

    public VeiculoController(ILogger<VeiculoController> logger)
    {
        _logger = logger;
    }
    /*[HttpGet(Name = "GetVeiculo")]
    public IEnumerable<Veiculo> Get()
    {
        List<Veiculo> veic = new()
        {
            new Veiculo("ABC1234", "1"),
            new Veiculo("CBA1234", "2"),
            new Veiculo("ABC4321", "3"),
            new Veiculo("CBA4321", "4")
        };
        return veic;
    }*/
    //get: API/veiculo/listar
    [HttpGet(Name = "GetVeiculo")]
    [Route("listar")]
    public IActionResult Listar()
    {
        return Ok(veic);
    }
    
    //GET: API/veiculo/buscar/{placa}
    [HttpGet()]
    [Route("buscar/{placa}")]
    public IActionResult Buscar(string placa)
    {
        Veiculo veicTemp = veic.Find(x => x.Placa == placa);
        if(veicTemp is not null)
            return Ok(veicTemp);
        else
            return NotFound();
    }

    //POST: API/veiculo/cadastrar
    [HttpPost()]
    [Route("cadastrar")]
    public IActionResult Cadastrar(VeiculoController veic)
    {
        veic.Add(veic)
        return Created("", veic);
    }

    
}