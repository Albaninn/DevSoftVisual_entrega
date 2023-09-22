using System.ComponentModel.DataAnnotations;

public class Carro : Veiculo
{
    public int? Id {get; set;};
    public int? _NroPortas {get; set;};

    public Veiculo _veiculo;


    public Carro()
    {
        Id = null;
        _NroPortas = null;
        _veiculo = new();

    }

}
