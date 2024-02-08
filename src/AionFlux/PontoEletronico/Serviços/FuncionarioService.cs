using PontoEletronico.Regras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico.Serviços
{
    public class FuncionarioService : IFuncionarioService
    {
        public Funcionario Adicionar(Funcionario objeto)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> AtualizarAsync(Funcionario objeto)
        {
            throw new NotImplementedException();
        }

        public Task Deletar(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> Obter(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Funcionario>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Funcionario>> ObterTodos(int[] id)
        {
            throw new NotImplementedException();
        }
    }
}

