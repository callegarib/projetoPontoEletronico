using Microsoft.AspNetCore.Mvc;
using PontoEletronico;
using System;

namespace AionFlux.Mvc.Controllers
{
    // Controlador para as operações relacionadas ao CartaoPonto
    [ApiController]
    [Route("api/[controller]")]
    public class CartaoPontoController : ControllerBase
    {
        private readonly AdminCartaoPonto adminCartaoPonto;

        public CartaoPontoController(AdminCartaoPonto adminCartaoPonto)
        {
            this.adminCartaoPonto = adminCartaoPonto;
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