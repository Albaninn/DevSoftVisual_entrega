using System.ComponentModel.DataAnnotations;

public class Marca
{
    [Key]
    public int? Id {get; set;}
    public string? _DescricaoMarca {get; set;}



    public Marca()
    {
        Id = null;
        _DescricaoMarca = string.Empty;
    }
}
