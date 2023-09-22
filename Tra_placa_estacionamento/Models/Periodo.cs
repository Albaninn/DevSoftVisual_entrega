using System.ComponentModel.DataAnnotations;

internal class Periodo
{
    [Key]

    public int? Id {get; set;}
    public DateTime? _HoraEntrada {get; set;}
    public DateTime? _HoraSaida {get; set;}



    public Periodo()
    {
        id = new int();
        _HoraEntrada = new DateTime();
        _HoraSaida = null;
    }

}

