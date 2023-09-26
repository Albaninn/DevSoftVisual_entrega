using System.ComponentModel.DataAnnotations;
public class Ticket
{   
    [Key]
    public int Id {get; set;}
    public  int CodTicket {get; set;}
    public Servico? PublicServico {get; set;}

}
