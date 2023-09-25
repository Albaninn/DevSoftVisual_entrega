using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    public string? Placa {get; set;}
    public int? Id {get; set;}
    public string? Descricao {get; set;}
    public Modelo? Modelo {get; set;}
}