using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    public string? Placa {get; set;}
    private int? Id {get; set;}
    private string? Descricao {get; set;}
    private Modelo? Modelo {get; set;}
}