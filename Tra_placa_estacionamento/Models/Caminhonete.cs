using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Caminhonete : Veiculo
{
    [Key]
    private int? _IdCaminhonete ;
    private int? _NroPortas;
    private string? _Combustivel;

    private Veiculo _veiculo;


    public int? id
    {
        get=> _IdCaminhonete;
        set=> _IdCaminhonete = 0;

    }

    public int? NroPortas
    {
        get => _NroPortas;
        set => _NroPortas = value;
    }

    public string? Combustivel
    {
        get=> _Combustivel;
        set=> _Combustivel = value;

    }


    public Caminhonete()
    {   
        _IdCaminhonete = null;
        _NroPortas = null;
        _Combustivel = string.Empty;
        _veiculo = new();
    }
        
 
}