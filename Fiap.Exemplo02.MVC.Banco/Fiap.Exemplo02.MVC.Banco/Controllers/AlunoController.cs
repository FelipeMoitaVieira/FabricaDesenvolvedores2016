using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Banco.Models;
using Fiap.Exemplo02.MVC.Banco.UnitsOfWork;
using Fiap.Exemplo02.MVC.Banco.ViewModels;
using System;

namespace Fiap.Exemplo02.MVC.Banco.Controllers
{
    public class AlunoController : Controller
    {

        #region FIELD
        //private PortalContent _context = new PortalContent();
        private UnitOfWork _unit = new UnitOfWork();
        #endregion

        #region GET

        [HttpGet]
        public ActionResult Cadastrar(string msg)
        {
            var viewModel = new AlunoViewModel()
            {
                ListaGrupo = ListarGrupos(),
                Mensagem = msg,
                DataNascimento = DateTime.Now,
                Alunos = _unit.AlunoRepository.Listar()
            };

            return View(viewModel);
        }


        [HttpGet]
        public ActionResult Listar(string msg)
        {
            // include -> busca o relacionamento (preenche o grupo que o aluno possui), faz o join
            //var lista = _context.Aluno.Include("Grupo").ToList();


            var alunos = new AlunoViewModel()
            {
                Alunos = _unit.AlunoRepository.Listar(),
                ListaGrupo = ListarGrupos(),
                Mensagem = msg

            };

            return View(alunos);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = _unit.AlunoRepository.BuscarPorId(id);
            var viewModel = new AlunoViewModel()
            {
                ListaGrupo = ListarGrupos(),
                Nome = aluno.Nome,
                Bolsa = aluno.Bolsa,
                Desconto = aluno.Desconto,
                Id = aluno.Id,
                DataNascimento = aluno.DataNascimento,
                GrupoId = aluno.GrupoId
            };
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Buscar(string nomeBusca, int? idGrupo)
        {

            var lista = _unit.AlunoRepository.BuscarPor(a => a.Nome.StartsWith(nomeBusca) && 
            (a.GrupoId == idGrupo || idGrupo == null));
            

            return PartialView("_tabela", lista);
        }
        #endregion

        #region POST
        [HttpPost]
        public ActionResult Cadastrar(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                var aluno = new Aluno()
                {
                    Nome = alunoViewModel.Nome,
                    DataNascimento = alunoViewModel.DataNascimento,
                    Id = alunoViewModel.Id,
                    Bolsa = alunoViewModel.Bolsa,
                    Desconto = alunoViewModel.Desconto,
                    GrupoId = alunoViewModel.GrupoId
                };

                _unit.AlunoRepository.Cadastrar(aluno);
                _unit.Salvar();
            
                return RedirectToAction("Cadastrar", new { msg = "Aluno Cadastrado" });
            }
            else
            {
               alunoViewModel.ListaGrupo = ListarGrupos();
                return View(alunoViewModel);
            }
        }


        [HttpPost]
        public ActionResult Excluir(int alunoId)
        {
            _unit.AlunoRepository.Remover(alunoId);
            _unit.Salvar();
            
            return RedirectToAction("Listar", new { msg = "Aluno Excluído" });
        }


        [HttpPost]
        public ActionResult Editar(Aluno aluno)
        {
            _unit.AlunoRepository.Atualizar(aluno);
            _unit.Salvar();
            return RedirectToAction("Listar", new { msg = "Aluno Atualizado" });
        }

        #endregion

        #region PRIVATE

        private SelectList ListarGrupos()
        {
            var lista = _unit.GrupoRespository.Listar();
            return new SelectList(lista, "Id", "Nome");
        }

        #endregion

        #region DISPOSE
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
        #endregion





    }
}
