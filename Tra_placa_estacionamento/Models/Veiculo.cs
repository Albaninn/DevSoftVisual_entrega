using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    public int? Id {get; set;}
    public string? placa {get; set;}
    public string? _Descricao {get; set;}
    public enum Cor {Vermelho, Branco, Preto, Prata} {get; set;}

    private Cor _CorExterna;
    private Modelo? _Modelo;


    public Veiculo()
    {
        Id = null;
        _Modelo = new();
        _Placa = string.Empty;
        _CorExterna = Cor.Branco;
    }
    
}
