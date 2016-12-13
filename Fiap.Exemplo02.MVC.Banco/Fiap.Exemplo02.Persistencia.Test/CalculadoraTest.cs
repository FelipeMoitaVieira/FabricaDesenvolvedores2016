using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fiap.Exemplo02.Persistencia.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Calcular_Fatorial_OK()
        {
            //inicializar os objetos
            Calculadora calc = new Calculadora();
            //Chamar método que será testado
            var resultado = calc.Fatorial(5);
            //Validar o resultado obtido
            Assert.AreEqual(120, resultado);
        }

        [TestMethod]
        public void Calcular_Fatorial_Zero()
        {
            // inicializar os objetos
            Calculadora calc = new Calculadora();
            //Chamar método que será testado
            var resultado = calc.Fatorial(0);
            //Validar o resultado obtido
            Assert.AreEqual(1, resultado);
        }
    }
}
