using System.ComponentModel.DataAnnotations;

public class Tamanho
{
    [Key]
    private int? Id {get; set;}
    private string? Descricao {get; set;}
}