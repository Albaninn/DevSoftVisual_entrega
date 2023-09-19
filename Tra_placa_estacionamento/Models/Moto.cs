using System.ComponentModel.DataAnnotations;

public class Moto : Veiculo
{
    [Key]
    public new int? Id {get; set;}
    public Boolean? Bau {get; set;}

}