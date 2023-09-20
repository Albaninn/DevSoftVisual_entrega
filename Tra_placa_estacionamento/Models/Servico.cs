using System.ComponentModel.DataAnnotations;
public class Servico
{
	[Key]
	private int? _idServico;
	private double _ValorPagar;
	private string? _DescricaoServico;
    private double _ValorHora;

    private Periodo _Periodo;//usar para retornar os horários de permanencia e multiplicar pelo valorHora;



	public int? IdServico
	{
		get=> _idServico;
		set=> _idServico = value;
	}
	public double ValorPagar
	{
		get=> _ValorPagar;
		set=> _ValorPagar= value;
	}

	public string? DescricaoServico
	{
		get=> _DescricaoServico;
		set=> _DescricaoServico = value;
	}

    public double? ValorHora
    {
        get => _ValorHora;
        set => _ValorHora= 5.50;

    }


    public Servico()
	{
		_idServico = new int();
		_ValorPagar = 0.0;
		_DescricaoServico = string.Empty;
	}








}
