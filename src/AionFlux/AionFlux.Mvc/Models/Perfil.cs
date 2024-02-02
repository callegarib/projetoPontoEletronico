using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico
{
    public class Perfil
    {
        private static Perfil Padrao { get; set; }

        public Perfil()
        {
            // Restante do código...
        }

       public static Perfil PerfilDeTrabalhoPadrao()
        {
            if (Padrao == null)
            {
                Padrao = new Perfil()
                {
                    Fixo = true,
                    HoraFim = new DateTime(2024, 01, 01, 18, 00, 00),
                    HoraInicio = new DateTime(2024, 01, 01, 08, 00, 00),
                    InicioIntervalo = new DateTime(2024, 01, 01, 12, 00, 00),
                    TempoDeIntervalo = TimeSpan.FromHours(2),
                    Tolerancia = TimeSpan.FromMinutes(10)
                };
            }
            return Padrao;
        }

        public bool Fixo { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public DateTime InicioIntervalo { get; set; }
        public TimeSpan TempoDeIntervalo { get; set; }
        public TimeSpan Tolerancia { get; set; }
    }
}

