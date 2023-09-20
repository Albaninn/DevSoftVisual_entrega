using System.ComponentModel.DataAnnotations;
public class Servico
{
	[Key]
	private int? _idServico;
	private double _ValorPagar;
	private string? _DescricaoServico;


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



	public Servico()
	{
		_idServico = new int();
		_ValorPagar = 0;
		_DescricaoServico = string.Empty;
	}







}