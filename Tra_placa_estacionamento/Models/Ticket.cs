using System.ComponentModel.DataAnnotations;
public class Ticket
{   
    [Key]
    public int Id {get; set;}
    public  int _codTicket {get; set;}
    


    private Periodo _periodo;
    private Servico _servico;


    public Ticket()
    {
        Id = new int();
        _codTicket = new int();
        _periodo = new Periodo();
        
    }

}
