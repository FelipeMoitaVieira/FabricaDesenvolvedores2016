﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class ErroController : Controller
    {
        // GET: Erro
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}