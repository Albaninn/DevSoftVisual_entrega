using System.ComponentModel.DataAnnotations;
public class Ticket
{   
    [Key]
    private int _idTicket;
    private int _codTicket;
    private double _ValorHoraEstacionamento;




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

    public double? ValorHoraEstacionamento
    {
        get => _ValorHoraEstacionamento;
        set=> _ValorHoraEstacionamento = 5.50;
        
    }



    public Ticket()
    {
        _idTicket = new int();
        _codTicket = new int();
        _ValorHoraEstacionamento = _ValorHoraEstacionamento;
    }

}