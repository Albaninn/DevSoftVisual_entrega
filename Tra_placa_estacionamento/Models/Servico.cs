using System.ComponentModel.DataAnnotations;
public class Servico
{
[Key]
public int? Id {get; set;}
public double _ValorPagar {get; set;}
public string? _DescricaoServico {get; set;}
public double _ValorHora {get; set;}

private Periodo _Periodo;//usar para retornar os horários de permanencia e multiplicar pelo valorHora;




public Servico()
{
	Id = new int();
	_ValorPagar = 0.0;
	_DescricaoServico = string.Empty;
}








}
