using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    private int? _IdCliente;
    private string? _Nome;
    private string? _Cpf;
    private string? _Email;

    /*public void SolicitaTicket {get; set;}*/


    public int? IdCliente
    {
        get=> _IdCliente;
        set=> _IdCliente = value;
    }

    public string? Nome
    {
        get=>_Nome;
        set=> _Nome = value;
    }

    public string? Cpf
    {
        get=>_Cpf;
        set=> _Cpf = value;
    }

    public string? Email
    {
        get=> _Email;
        set=>_Email = value;
    }



    public Cliente()
    {
        _IdCliente = null;
        _Cpf = string.Empty;
        _Nome = string.Empty;
        _Email = string.Empty;
    }
}