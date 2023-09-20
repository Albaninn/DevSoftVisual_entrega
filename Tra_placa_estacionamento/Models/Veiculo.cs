using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    private string? _Placa;
    private int? _IdVeiculo;
    private string? _Descricao;
    public enum Cor {Vermelho, Branco, Preto, Prata};

    private Cor _CorExterna;
    private Modelo? _Modelo;


    public Cor CorExterna
    {
        get=>_CorExterna;
        set=>_CorExterna = value;
    }


    public string? Placa
    {
        get => _Placa;
        set => _Placa = value;
    }

    public int? IdVeiculo
    {
        get => _IdVeiculo;
        set => _IdVeiculo = 0;
    }

    public string? Descricao
    {
        get=> _Descricao;
        set=> _Descricao = value;

    }

    
    public Veiculo()
    {
        _IdVeiculo= null;
        _Modelo = new();
        _Placa = string.Empty;
        _CorExterna = Cor.Branco;
    }
    
}