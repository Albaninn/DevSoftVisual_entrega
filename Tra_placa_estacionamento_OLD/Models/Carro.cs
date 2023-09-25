using System.ComponentModel.DataAnnotations;

public class Carro : Veiculo
{
    [Key]
    public new int? Id {get; set;}
    public int? NroPortas {get; set;}

}