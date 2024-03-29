﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PontoEletronico;

namespace AionFlux.Mvc.Controllers
{
    [Authorize]
    public class PontoEletronicoController : Controller
    {
        private readonly AdminCartaoPonto adminCartaoPonto;

        public PontoEletronicoController(AdminCartaoPonto adminCartaoPonto)
        {
            this.adminCartaoPonto = adminCartaoPonto;
        }

        public IActionResult Index()
        {
            return View(adminCartaoPonto.cartoesPonto);
        }
    }
}
