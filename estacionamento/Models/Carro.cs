using System.ComponentModel.DataAnnotations;

public class Carro
{
    [Key]
    public string placa {get; set;}
    public string descricao {get; set;}
    
}