using Fiap.Exemplo03.UI.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.Web.MVC.Tests.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Listar()
        {
            return View();
        }
       
    }
}