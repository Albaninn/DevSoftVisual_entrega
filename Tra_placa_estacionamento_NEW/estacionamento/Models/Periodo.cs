using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

public class Periodo
{
    [Key]
    public int? Id {get; set;}
    public DateTime? HoraEntrada { get; set; }
    public DateTime? HoraSaida {get; set;}




    //----------------------------------------------------------------


    public Periodo? solicitarEntrada()
    { this.HoraEntrada = DateTime.Now;
        return this;
    }


    public Periodo? solicitarSaida()
    { this.HoraSaida = DateTime.Now;
      return this;       
     }

    public TimeSpan? processarPermanencia()
    {
        if (HoraEntrada != default && HoraSaida != default)
        {
            var tempo = HoraSaida - HoraEntrada;
            return tempo;
        }
        else
        {
            return null;
        }
    }
}


    


