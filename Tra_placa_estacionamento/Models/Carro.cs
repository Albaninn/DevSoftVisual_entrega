using System.ComponentModel.DataAnnotations;

public class Carro : Veiculo
{
    [Key]
    private int? _IdCarro;
    private int? _NroPortas;

    private Veiculo _veiculo;


    public int? IdCarro
    {
        get=> _IdCarro;
        set=> _IdCarro = value;
    }


    public Carro()
    {
        _IdCarro = null;
        _NroPortas = null;
        _veiculo = new();

    }

}