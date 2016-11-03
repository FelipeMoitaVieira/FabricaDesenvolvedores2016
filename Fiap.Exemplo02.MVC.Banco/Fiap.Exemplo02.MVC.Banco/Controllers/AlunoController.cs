using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Banco.Models;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class AlunoController : Controller
    {
        private PortalContent _context = new PortalContent();
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            
            
            _context.Aluno.Add(aluno);
            _context.SaveChanges();
            TempData["msg"] = "Aluno Cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Aluno> _lista = _context.Aluno.ToList();
            return View(_lista);
        }
        
        public ActionResult Excluir(int id)
        {
            Aluno aluno = _contexto.Alunoes.Find(id);
            _contexto.Alunoes.Remove(aluno);
            _contexto.SaveChanges();

            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            Aluno aluno = _contexto.Alunoes.Find(id);
            
            return RedirectToAction("Cadastrar", aluno);
        }
        
    }
}
