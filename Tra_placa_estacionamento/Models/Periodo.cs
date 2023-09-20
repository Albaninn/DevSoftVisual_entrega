using System.ComponentModel.DataAnnotations;

internal class Periodo
{
    [Key]

    private int? _idPeriodo;
    private DateTime? _HoraEntrada;
    private DateTime? _HoraSaida;



    public int? IdPeriodo
    {

        get=>_idPeriodo;
        set=>_idPeriodo = 0;


    }

    public DateTime? HoraEntrada
    {
        get=>_HoraEntrada;
        set=>_HoraEntrada = value;
    }

    public DateTime? HoraSaida
    {
        get=> _HoraSaida;
        set=> _HoraSaida = value;
    }



    public Periodo()
    {
        _idPeriodo = new int();
        _HoraEntrada = new DateTime();
        _HoraSaida = null;
    }

}

