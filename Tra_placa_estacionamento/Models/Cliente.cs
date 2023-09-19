using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    private int? _Id {get; set;}
    private string? _Nome {get; set;}
    private string? _Cpf {get; set;}
    private string? _Email {get; set;}

    /*public void SolicitaTicket {get; set;}*/
}