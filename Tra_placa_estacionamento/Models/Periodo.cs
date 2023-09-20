using System.ComponentModel.DataAnnotations;

internal class Periodo
{
    [Key]
    private int? _idPerido;
    private DateTime? _HoraEntrada;
    private DateTime? _HoraSaida;



    public int? IdPerido
    {
        get=>_idPerido;
        set=>_idPerido = 0;
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
