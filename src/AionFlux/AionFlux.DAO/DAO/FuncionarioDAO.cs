using AionFlux.DAO.Regras;
using AionFlux.DAO.Settings;
using AionFlux.DAO.ValueObjects;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionFlux.DAO.DAO
{
    public class FuncionarioDAO : IFuncionarioDAO
    {
        public List<FuncionarioVo> Funcionarios { get; set; }

        public FuncionarioDAO() {
            Funcionarios = new List<FuncionarioVo>();

        }
        public Task AtualizarRegistro(FuncionarioVo objetoParaAtualizar)
        {
            var idAtualizar = Funcionarios.Find(funcionario => funcionario.Id.Equals(objetoParaAtualizar.Id));
            Funcionarios.Remove(idAtualizar);
            Funcionarios.Add(objetoParaAtualizar);
            return Task.CompletedTask;
        }

        public int CriarRegistro(FuncionarioVo objetoVo)
        {
            objetoVo.Id = Funcionarios.Count + 1;
            Funcionarios.Add(objetoVo);
            return objetoVo.Id;
        }

        public Task DeletarRegistro(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioVo> ObterRegistro(int ID)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioVo> ObterRegistros()
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioVo> ObterRegistros(int ID)
        {
            throw new NotImplementedException();
        }
    }

}
