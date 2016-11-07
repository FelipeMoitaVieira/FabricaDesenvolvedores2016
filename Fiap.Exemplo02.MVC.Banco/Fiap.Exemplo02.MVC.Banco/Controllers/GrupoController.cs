﻿using Fiap.Exemplo02.MVC.Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class GrupoController : Controller
    {
        private PortalContent _context = new PortalContent();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Grupo grupo)
        {
            _context.Grupo.Add(grupo);
            _context.SaveChanges();
            TempData["msg"] = "Grupo Cadastrado com Sucesso";

            return RedirectToAction("Cadastrar");
        }
        [HttpGet]
        public ActionResult Listar()
        {
            var _lista = _context.Grupo.ToList();
            return View(_lista);
        }
    }
}