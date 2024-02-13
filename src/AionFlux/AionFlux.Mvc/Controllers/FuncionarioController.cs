using Microsoft.AspNetCore.Mvc;
using PontoEletronico;

namespace AionFlux.Mvc.Controllers
{
    public class FuncionarioController : Controller
    {
        private AdminCartaoPonto AdminCartaoPonto;

        public FuncionarioController(AdminCartaoPonto adminCartaoPonto)
        {
            AdminCartaoPonto = adminCartaoPonto;
        }

        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionarios = AdminCartaoPonto.funcionarios;
            return View(funcionarios);
        }

        // GET: Funcionario/Detalhes/5
        public ActionResult Detalhes(int id)
        {
            var funcionario = AdminCartaoPonto.funcionarios.Find(f => f.Id == id);
            return View(funcionario);
        }

        // GET: Funcionario/Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Funcionario/Criar

        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string CPF { get; set; }
        //public string RG { get; set; }
        //public string Telefone { get; set; }
        //public string Endereco { get; set; }
        //public string Email { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind("Id,Nome,CPF,RG,Telefone,Endereco, Email")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                AdminCartaoPonto.CadastrarFuncionario(funcionario);
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        // GET: Funcionario/Editar/5
        public ActionResult Editar(int id)
        {
            var funcionario = AdminCartaoPonto.funcionarios.Find(f => f.Id == id);
            return View(funcionario);
        }

        // POST: Funcionario/Editar/5
        [HttpPost]
        public ActionResult Editar(int id, Funcionario novoFuncionario)
        {
            if (ModelState.IsValid)
            {
                AdminCartaoPonto.EditarFuncionario(id, novoFuncionario);
                return RedirectToAction("Index");
            }
            return View(novoFuncionario);
        }

        // GET: Funcionario/Excluir/5
        public ActionResult Excluir(int id)
        {
            var funcionario = AdminCartaoPonto.funcionarios.Find(f => f.Id == id);
            return View(funcionario);
        }

        // POST: Funcionario/Excluir/5
        [HttpPost, ActionName("Excluir")]
        public ActionResult ConfirmarExclusao(int id)
        {
            AdminCartaoPonto.RemoverFuncionario(id);
            return RedirectToAction("Index");
        }
    }
}

