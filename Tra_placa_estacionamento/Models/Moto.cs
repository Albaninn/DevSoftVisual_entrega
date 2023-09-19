using System.ComponentModel.DataAnnotations;

public class Moto : Veiculo
{
    [Key]
    privata new int? Id {get; set;}
    private Boolean? Bau {get; set;}

}