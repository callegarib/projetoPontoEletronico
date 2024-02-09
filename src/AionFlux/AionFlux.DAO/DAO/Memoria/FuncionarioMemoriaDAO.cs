using AionFlux.DAO.Regras;
using AionFlux.DAO.ValueObjects;

namespace AionFlux.DAO.DAO.Memoria
{
    public class FuncionarioMemoriaDAO : IFuncionarioDAO
    {
        public List<FuncionarioVo> Funcionarios { get; set; }
        public FuncionarioMemoriaDAO()
        {
            Funcionarios = new();

            FuncionarioVo clienteVo = new FuncionarioVo()
            {
                Id = 1,
                Nome = "Exemplo de cliente para memoria",
                UserId = Guid.NewGuid()
            };
            Funcionarios.Add(clienteVo);
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
            var idAtualizar = Funcionarios.Find(funcionario => funcionario.Id.Equals(ID));
            Funcionarios.Remove(idAtualizar);
            return Task.CompletedTask;
        }

        public Task<FuncionarioVo> ObterRegistro(int ID)
        {
            var funcionario = Funcionarios.Find(funcionario => funcionario.Id.Equals(ID));
            return Task.FromResult(funcionario);
        }

        public List<FuncionarioVo> ObterRegistros(int ID)
        {
            var funcionarios = Funcionarios.FindAll(funcionario => funcionario.Id.ToString().Contains(ID.ToString()));
            return funcionarios;
        }

        public List<FuncionarioVo> ObterRegistros()
        {
            return Funcionarios;
        }

    }
}
