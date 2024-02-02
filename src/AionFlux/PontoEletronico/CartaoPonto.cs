using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico
{
    public class CartaoPonto
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime Data { get; set; }
        public List<Registro> Registros { get; set; } = new List<Registro>();
    }
}

