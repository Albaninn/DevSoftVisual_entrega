using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int? Id {get; set;}
    public string? Nome {get; set;}
    public string? Cpf {get; set;}
    public string? Email {get; set;}

    /*public void SolicitaTicket {get; set;}*/
}