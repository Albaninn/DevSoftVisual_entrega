using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int? Id {get; set;};
    public string? _Nome {get; set;};
    public string? _Cpf {get; set;};
    public string? _Email {get; set;};

    

    public Cliente()
    {
        Id = null;
        _Cpf = string.Empty;
        _Nome = string.Empty;
        _Email = string.Empty;
    }
}
