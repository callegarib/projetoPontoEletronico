using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PontoEletronico.Regras
{
    public interface IFuncionarioService:
    
    IAdicionar<Funcionario>,
    IAtualizar<Funcionario>,
    IDeletar<Funcionario>,
    IObter<Funcionario>
    {
    }
}
