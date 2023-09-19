using System.ComponentModel.DataAnnotations;

public class Modelo
{
    [Key]
    private int? Id {get; set;}
    private string? Descricao {get; set;}
    private Marca? Marca {get; set;}
    private Tamanho? Tamanho {get; set;}
}
