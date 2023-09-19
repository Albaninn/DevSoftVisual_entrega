using System.ComponentModel.DataAnnotations;

public class Modelo
{
    [Key]
    public int? Id {get; set;}
    public string? Descricao {get; set;}
    public Marca? Marca {get; set;}
}
