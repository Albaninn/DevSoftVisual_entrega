using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    public int? Id {get; set;}
    public string? Placa {get; set;}
    public string? Descricao {get; set;}

    public enum Cor {Vermelho, Branco, Preto, Prata}

    public Cor CorExterna {get; set;}
    public Modelo?  Modelo {get; set;}
}
