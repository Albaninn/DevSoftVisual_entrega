using System.ComponentModel.DataAnnotations;

public class Periodo
{
    [Key]

    public int? Id {get; set;}
    public DateTime? HoraEntrada {get; set;}
    public DateTime? HoraSaida {get; set;}
}

