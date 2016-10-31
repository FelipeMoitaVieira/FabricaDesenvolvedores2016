using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Banco.Exceptions;
using Fiap.Banco.Model;

namespace Fiap.Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            var cc = new ContaCorrente()
            {
                Agencia = 3042,
                DataAbertura = DateTime.Parse("25/10/2016"),
                Numero = 55223344,
                Saldo = 500,
                Tipo = TipoConta.Comum
                
            };

            var cp = new ContaPoupanca(0.01m)
            {
                Agencia = 3042,
                DataAbertura = DateTime.Parse("20/10/2016"),
                Numero = 11447788,
                Saldo = 1000,
                Taxa = 0.005m
                
            };
            try
            {
                //cp.Retirar(1001);
                cc.Retirar(501);
            }
            catch (SaldoIndisponivelException e)
            {

                Console.WriteLine(e.Message);
            }
            
            

            
        }
    }
}
