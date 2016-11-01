using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _lista = new List<Cliente>();
        private static List<string> _listaOpcao = new List<string>() {"Solteiro","Casado","Divorciado","Separado Judicialmente","Viúvo" };
        

        [HttpGet]
       public ActionResult Cadastrar()
        {
           
            ViewBag.EstadoCivil = new SelectList(_listaOpcao);

            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _lista.Add(cliente);

            TempData["msg"] = "Cliente Cadastrado";

            return RedirectToAction("Cadastrar");
        }

        public ActionResult Listar()
        {
           
            return View(_lista);
        }
    }
}