using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
public class Ticket
{   
    [Key]
    public int Id {get; set;}
    public  int CodTicket {get; set;}

    public Servico Servico {get; set;}//chave estrangeira de servico
    public Veiculo Veiculo { get; set;}//chave estrangeira de veiculo

    public Ticket(){
        this.Id = 0;
        this.CodTicket = 0;
        Servico._Periodo.solicitarEntrada();

    }
    //-------------------------------------------------------------------------

    public virtual ICollection<Periodo> Periodo { get; set; }//propiedade do sistema para interligar/mapear chaves
    public virtual ICollection<Veiculo> Veiculos { get; set; }//propiedade do sistema para interligar/mapear chaves   


    //----------------------------------------------------------------

    public Ticket solicitarTicket()
    { 
        
        return new Ticket();
         
    }


}

