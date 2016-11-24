using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.UnitsOfWork;
using System.Web.Mvc;


namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class EnderecoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();


       [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Cadastrar(Endereco endereco)
        {
            _unit.EnderecoRepository.Cadastrar(endereco);
            _unit.Salvar();
            TempData["msg"] = "Endereço Cadastrado com Sucesso";


            return RedirectToAction("Cadastrar");
        }
    }
}