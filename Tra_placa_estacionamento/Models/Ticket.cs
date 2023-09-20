using System.ComponentModel.DataAnnotations;
public class Ticket
{   
    [Key]
    private int _idTicket;
    private int _codTicket;
    


    private Periodo _periodo;
    private Servico _servico;



    public int? IdTicket
    {
        get=>_idTicket;
        set=>_idTicket = 0;
    }

    public int? CodTicket
    {
        get=>_codTicket;
        set=>_codTicket = 0;

    }

    
    public Ticket()
    {
        _idTicket = new int();
        _codTicket = new int();
        _periodo = new Periodo();
        
    }

}
