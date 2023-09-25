using System.ComponentModel.DataAnnotations;

public class Moto : Veiculo
{
    [Key]
    public int? Id {get; set;}
    public Boolean? _Bau {get; set;}

    private Veiculo _veiculo;

   
    public Moto()
    {
        _Bau = false;
         Id = null;
        _veiculo = new();
    }

}
