using System.ComponentModel.DataAnnotations;

public class Marca
{
    [Key]
    private int? _IdMarca;
    private string? _DescricaoMarca;


    public int? IdMarca
    {
        get=> _IdMarca;
        set=> _IdMarca = value;
    }

    public string? DescricaoMarca
    {
        get=>_DescricaoMarca;
        set=>_DescricaoMarca = value;
    }



    public Marca()
    {
        _IdMarca = null;
        _DescricaoMarca = string.Empty;
    }
}