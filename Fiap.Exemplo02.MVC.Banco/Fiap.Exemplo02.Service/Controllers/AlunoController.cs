using Fiap.Exemplo02.Dominio.Models;
using Fiap.Exemplo02.MVC.Banco.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fiap.Exemplo02.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class AlunoController : ApiController

    {
        private UnitOfWork _unity = new UnitOfWork();

        public ICollection<Aluno> Get()
        {
            return _unity.AlunoRepository.Listar();
        }

        public Aluno Get(int id)
        {
            return _unity.AlunoRepository.BuscarPorId(id);
        }

        public ICollection<Aluno> Get(string nome)
        {
            return _unity.AlunoRepository.BuscarPor(a => a.Nome.Contains(nome));
        }

        public IHttpActionResult Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _unity.AlunoRepository.Cadastrar(aluno);
                _unity.Salvar();
                var uri = Url.Link("DefaultApi", new { id = aluno.Id });
                return Created<Aluno>(new Uri(uri), aluno);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public IHttpActionResult Put(int id, Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno.Id = id;
                _unity.AlunoRepository.Atualizar(aluno);
                _unity.Salvar();
                return Ok(aluno);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        public void Delete(int id)
        {
            _unity.AlunoRepository.Remover(id);
            _unity.Salvar();
        }


    }
}
