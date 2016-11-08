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
            var lista = _context.Grupo.ToList();
            ViewBag.grupos = new SelectList(lista, "Id", "Nome");
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
            // include -> busca o relacionamento (preenche o grupo que o aluno possui), faz o join
            //var lista = _context.Aluno.Include("Grupo").ToList();
            List<Aluno> _lista = _context.Aluno.ToList();
            return View(_lista);
        }

        
        [HttpPost]
        public ActionResult Excluir(int alunoId)
        {
            Aluno aluno = _context.Aluno.Find(alunoId);
            _context.Aluno.Remove(aluno);
            _context.SaveChanges();
            TempData["msg"] = "Aluno Excluído";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = _context.Aluno.Find(id);
            
            return View("Editar", aluno);
        }

        [HttpPost]
        public ActionResult Editar(Aluno aluno)
        {
            _context.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Aluno Atualizado";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Buscar(string nomeBusca)
        {
            var lista = _context.Aluno.Where(a => a.Nome.Contains(nomeBusca)).ToList();
            

            return View("Listar",lista);
        }
        
    }
}
