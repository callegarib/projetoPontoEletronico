using Microsoft.AspNetCore.Mvc;
using PontoEletronico;
using PontoEletronico.Regras;
using PontoEletronico.Serviços;

namespace AionFlux.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController :ControllerBase
    { 
        public readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet]
        public async Task<Funcionario[]> BuscarFuncinarios()
        {
            return (await _funcionarioService.ObterTodos()).ToArray();
        }

        [HttpPost]
        public Task<Funcionario> Adicionar(Funcionario funcionario)
        {
            return Task.FromResult(_funcionarioService.Adicionar(funcionario));
        }

        [HttpPut]
        public async Task<Funcionario> Atualizar(Funcionario funcionario)
        {
            try
            {

                return await _funcionarioService.AtualizarAsync(funcionario);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public async Task Deletar(int ID)
        {
            try
            {
                await _funcionarioService.Deletar(ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}