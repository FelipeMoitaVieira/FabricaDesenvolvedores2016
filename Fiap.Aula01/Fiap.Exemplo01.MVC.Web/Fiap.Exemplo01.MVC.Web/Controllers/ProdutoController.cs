using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();


       [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]//carregar a página com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            _lista.Add(produto);
         
            ViewBag.prod = produto;


            TempData["msg"] = "Produto Cadastrado!";

            return RedirectToAction("Cadastrar",produto);
            //return Content("Nome: " + nome + " Valor: " + valor + " Quantidade: " + quantidade);
        }
    }
}