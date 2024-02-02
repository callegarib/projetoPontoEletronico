using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using PontoEletronico;
using System;
using System.Collections.Generic;

namespace AionFlux.Mvc.Controllers
{
    public class CartaoPontoController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]
        public class PontoEletronicoController : ControllerBase
        {
            private readonly AdminCartaoPonto adminCartaoPonto;

            public PontoEletronicoController(AdminCartaoPonto adminCartaoPonto)
            {
                this.adminCartaoPonto = adminCartaoPonto;
            }

            // Endpoint para cadastrar um funcionário
            [HttpPost("funcionario")]
            public IActionResult CadastrarFuncionario([FromBody] Funcionario funcionario)
            {
                adminCartaoPonto.CadastrarFuncionario(funcionario);
                return Ok(funcionario);
            }

            // Endpoint para editar um funcionário
            [HttpPut("funcionario/{funcionarioId}")]
            public IActionResult EditarFuncionario(int funcionarioId, [FromBody] Funcionario novoFuncionario)
            {
                adminCartaoPonto.EditarFuncionario(funcionarioId, novoFuncionario);
                return Ok();
            }

            // Endpoint para remover um funcionário
            [HttpDelete("funcionario/{funcionarioId}")]
            public IActionResult RemoverFuncionario(int funcionarioId)
            {
                adminCartaoPonto.RemoverFuncionario(funcionarioId);
                return Ok();
            }

            // Endpoint para cadastrar um registro
            [HttpPost("registro")]
            public IActionResult CadastrarRegistro([FromBody] Registro registro)
            {
                adminCartaoPonto.CadastrarRegistro(registro);
                return Ok(registro);
            }

            // Endpoint para editar um registro
            [HttpPut("registro/{registroId}")]
            public IActionResult EditarRegistro(int registroId, [FromBody] Registro novoRegistro)
            {
                adminCartaoPonto.EditarRegistro(registroId, novoRegistro);
                return Ok();
            }

            // Endpoint para remover um registro
            [HttpDelete("registro/{registroId}")]
            public IActionResult RemoverRegistro(int registroId)
            {
                adminCartaoPonto.RemoverRegistro(registroId);
                return Ok();
            }

            // Endpoint para cadastrar um cartão ponto
            [HttpPost("cartaoponto")]
            public IActionResult CadastrarCartaoPonto([FromBody] CartaoPonto cartaoPonto)
            {
                adminCartaoPonto.CadastrarCartaoPonto(cartaoPonto);
                return Ok(cartaoPonto);
            }

            // Endpoint para editar um cartão ponto
            [HttpPut("cartaoponto/{cartaoPontoId}")]
            public IActionResult EditarCartaoPonto(int cartaoPontoId, [FromBody] CartaoPonto novoCartaoPonto)
            {
                adminCartaoPonto.EditarCartaoPonto(cartaoPontoId, novoCartaoPonto);
                return Ok();
            }

            // Endpoint para remover um cartão ponto
            [HttpDelete("cartaoponto/{cartaoPontoId}")]
            public IActionResult RemoverCartaoPonto(int cartaoPontoId)
            {
                adminCartaoPonto.RemoverCartaoPonto(cartaoPontoId);
                return Ok();
            }
        }
    }
}
