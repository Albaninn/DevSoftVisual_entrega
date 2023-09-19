using System.ComponentModel.DataAnnotations;

public class Carro : Veiculo
{
    [Key]
    private new int? Id {get; set;}
    private int? NroPortas {get; set;}

}