using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public string? Cpf {get; set;}
    public int? Id {get; set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}
    public Veiculo? veiculo {get; set;}
}
