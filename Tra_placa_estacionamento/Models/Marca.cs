using System.ComponentModel.DataAnnotations;

public class Marca
{
    [Key]
    private int? Id {get; set;}
    private string? Descricao {get; set;}

}