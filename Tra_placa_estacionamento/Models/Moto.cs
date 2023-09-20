using System.ComponentModel.DataAnnotations;

public class Moto : Veiculo
{
    [Key]
    private int? _IdMoto;
    private Boolean? _Bau;

    private Veiculo _veiculo;

    public int? IdMoto
    {
        get=>_IdMoto;
        set=>_IdMoto = value;
    }

    public Boolean? Bau
    {
        get=>_Bau;
        set=>_Bau = value;
    }



    public Moto()
    {
        _Bau = false;
        _IdMoto = null;
        _veiculo = new();
    }

}