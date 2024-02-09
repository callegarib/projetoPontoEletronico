using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionFlux.DAO.ValueObjects
{
    public class FuncionarioVo : EntidadeBaseVo
    {
        public string Nome { get; set; }
        public Guid UserId { get; set; }
    }
}