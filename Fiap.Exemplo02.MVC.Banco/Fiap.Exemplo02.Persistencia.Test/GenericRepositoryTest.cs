using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.Exemplo02.MVC.Banco.Repositories;
using Fiap.Exemplo02.Dominio.Models;
using System.Data.Entity.Infrastructure;

namespace Fiap.Exemplo02.Persistencia.Test
{
    [TestClass]
    public class GenericRepositoryTest
    {
        private GenericRepository<Aluno> _repository;
        private PortalContext _context;


        [TestInitialize]
        public void Inicializacao()
        {
            //Inicializar os objetos
            _context = new PortalContext();
            _repository = new GenericRepository<Aluno>(_context);
        }

        [TestMethod]
        public void Cadastrar_Ok()
        {
            //Instanciar um Aluno
            var aluno = new Aluno()
            {
                Nome = "Teste",
                Bolsa = false,
                DataNascimento =DateTime.Now,
                Desconto = 10,
                Grupo = new Grupo() { Nome = "Grupo Teste" }
                
                
           };
            //Cadastro o Aluno
            _repository.Cadastrar(aluno);
           

            var r = _context.SaveChanges();

            Assert.AreEqual(2, r); //valida quantidade de registros afetados no commit
            Assert.AreNotEqual(aluno.Id, 0);
            

        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Cadastrar_Sem_Grupo_Exception()
        {
            var aluno = new Aluno()
            {
                Nome = "Teste",
                Bolsa = false,
                DataNascimento = DateTime.Now,
                Desconto = 10
            };
            //Cadastro o Aluno
            _repository.Cadastrar(aluno);
            _context.SaveChanges();
        }

    }
}
