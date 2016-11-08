using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.UnitsOfWork;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class AlunoController : Controller
    {
        //private PortalContent _context = new PortalContent();
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.GrupoRespository.Listar();
            ViewBag.grupos = new SelectList(lista, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            
            
            _unit.AlunoRepository.Cadastrar(aluno);
            _unit.Salvar();
            TempData["msg"] = "Aluno Cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            // include -> busca o relacionamento (preenche o grupo que o aluno possui), faz o join
            //var lista = _context.Aluno.Include("Grupo").ToList();
            var _lista = _unit.AlunoRepository.Listar();
            return View(_lista);
        }

        
        [HttpPost]
        public ActionResult Excluir(int alunoId)
        {
            _unit.AlunoRepository.Remover(alunoId);
            _unit.Salvar();
            TempData["msg"] = "Aluno Excluído";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = _unit.AlunoRepository.BuscarPorId(id);
            
            return View("Editar", aluno);
        }

        [HttpPost]
        public ActionResult Editar(Aluno aluno)
        {
            _unit.AlunoRepository.Atualizar(aluno);
            _unit.Salvar();
            TempData["msg"] = "Aluno Atualizado";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Buscar(string nomeBusca)
        {
            var lista = _unit.AlunoRepository.BuscarPor(a => a.Nome == nomeBusca);
            

            return View("Listar",lista);
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}
