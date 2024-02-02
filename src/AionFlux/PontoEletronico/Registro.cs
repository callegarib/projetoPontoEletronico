using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public TimeSpan TempoTrabalho { get; set; }
        public CartaoPonto CartaoPonto { get; set; }
        public TipoAcao TipoAcao { get; set; }
    }
}
