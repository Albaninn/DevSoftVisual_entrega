using System.ComponentModel.DataAnnotations;

internal class Periodo
{
    [Key]
    private string? _idPerido;
    private DateTime? _HoraEntrada;
    private DateTime? _HoraSaida;



    public string? IdPerido
    {
        get=>_idPerido;
        set=>_idPerido = value;
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
        _HoraEntrada = new DateTime();
        _HoraSaida = null;
    }

}