using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Caminhonete : Veiculo
{
    [Key]
    public int? Id {get; set;}
    public int? _NroPortas {get; set;};
    public string? _Combustivel {get; set;};

    public Veiculo _veiculo;



    public Caminhonete()
    {   
        Id = null;
        _NroPortas = null;
        _Combustivel = string.Empty;
        _veiculo = new();
    }
        
 
}
