using Exercicio03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio03.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {

            _lista.Add(produto);

            TempData["msg"] = "Produto Cadastrado com Sucesso";

            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

    }
}