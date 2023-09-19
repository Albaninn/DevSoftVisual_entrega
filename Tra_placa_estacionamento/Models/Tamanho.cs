using System.ComponentModel.DataAnnotations;

public class Tamanho
{
    [Key]
    public int? Id {get; set;}
    public string? Descricao {get; set;}
}