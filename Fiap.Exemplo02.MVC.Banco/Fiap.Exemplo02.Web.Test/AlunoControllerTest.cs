using Fiap.Exemplo02.Dominio.Models;
using Fiap.Exemplo02.MVC.Banco.Controllers;
using Fiap.Exemplo02.MVC.Banco.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Fiap.Exemplo02.Web.Test
{
    [TestClass]
    public class AlunoControllerTest
    {
        [TestMethod]
        public void Cadastrar_Get()
        {
            AlunoController controller = new AlunoController();
            var result = (ViewResult)controller.Cadastrar("teste");
            Assert.IsNotNull(result);
            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod]
        public void Cadastrar_Post()
        {
            AlunoController controller = new AlunoController();
            var aluno = new AlunoViewModel{
                Nome = "Teste",
                DataNascimento = DateTime.Now,
                Id = 100,
                Bolsa = true,
                Desconto = 10,
                GrupoId = 1

            };
            var result = (RedirectToRouteResult)controller.Cadastrar(aluno);
            Assert.IsNotNull(result);

            //var modelResultado = result.RouteName;
            //Assert.AreEqual(modelResultado, "Cadastrar");


        }
    }
}
