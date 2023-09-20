using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Modelo
{
    [Key]
    private int? _IdModelo;
    private string? _DescricaoModelo;

    public enum Tamanho {pequeno, medio, grande};


    private Marca? _Marca;
    protected Tamanho _Porte;


    
    public int? IdModelo
    {
        get=>_IdModelo;
        set=>_IdModelo = value;
    }

    public string? DescricaoModelo
    {
        get=> _DescricaoModelo;
        set=> _DescricaoModelo = value;
    }
   


    public Modelo()
    {
        _IdModelo = null;
        _DescricaoModelo = string.Empty;
        _Porte = Tamanho.pequeno;
        _Marca = new();
    }
}
