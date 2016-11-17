using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class GrupoController : Controller
    {
        //private PortalContent _context = new PortalContent();
        private UnitOfWork _unit = new UnitOfWork();


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Cadastrar(Grupo grupo)
        {
            _unit.GrupoRespository.Cadastrar(grupo);
            _unit.Salvar();
            TempData["msg"] = "Grupo Cadastrado com Sucesso";

            return RedirectToAction("Cadastrar");
        }



        [HttpGet]
        public ActionResult Listar()
        {
            var _lista = _unit.GrupoRespository.Listar();
            return View(_lista);
        }


        [HttpGet]
        public ActionResult Editar(int id)
        {
            var grupo = _unit.GrupoRespository.BuscarPorId(id);
            return View("Editar", grupo);
        }

        [HttpPost]
        public ActionResult Editar(Grupo grupo)
        {
            _unit.GrupoRespository.Atualizar(grupo);
            _unit.Salvar();
            TempData["msg"] = "Grupo Atualizado com Sucesso!";


            return RedirectToAction("Listar");
        }


        [HttpPost]
        public ActionResult Excluir(int grupoId)
        {
            var grupo = _unit.GrupoRespository.BuscarPorId(grupoId);
            if (grupo.Aluno.Count > 0)
            {
                
                throw new Exception("Não é possível excluir Grupo e/ou Projeto. Alunos cadastradas nesse Grupo/Projeto");
            }
            else
            {
                _unit.ProjetoRepository.Remover(grupoId);
                _unit.GrupoRespository.Remover(grupoId);
                _unit.Salvar();
                TempData["msg"] = "Grupo e Projeto Excluídos!";

            }
            


            return RedirectToAction("Listar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}