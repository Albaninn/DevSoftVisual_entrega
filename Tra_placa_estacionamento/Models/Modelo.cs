using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Modelo
{
    [Key]
    public int? Id {get; set;}
    public string? _DescricaoModelo {get; set;}

    public enum Tamanho {pequeno, medio, grande};


    private Marca? _Marca;
    protected Tamanho _Porte;



    public Modelo()
    {
         Id = null;
        _DescricaoModelo = string.Empty;
        _Porte = Tamanho.pequeno;
        _Marca = new();
    }
}
