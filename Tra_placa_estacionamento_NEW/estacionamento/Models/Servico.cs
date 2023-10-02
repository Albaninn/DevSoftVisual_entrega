using System.ComponentModel.DataAnnotations;
public class Servico
{
	[Key]
	public int? Id {get; set;}
	public double ValorPagar {get; set;}
	public string? DescricaoServico {get; set;}
	public double ValorHora {get; set;}
	
    public Cliente? Cliente { get; set; }

	public Periodo? Periodo {get; set;}//usar para retornar os horários de permanencia e multiplicar pelo valorHora;
}