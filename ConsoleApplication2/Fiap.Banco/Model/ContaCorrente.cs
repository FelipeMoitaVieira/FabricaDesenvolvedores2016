using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Banco.Exceptions;

namespace Fiap.Banco.Model
{
    public sealed class ContaCorrente : Conta
    {

        public TipoConta Tipo { get; set; }


        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }



        public override void Retirar(decimal valor)
        {
            
            if(Tipo == TipoConta.Comum && (Saldo - valor) < 0)
            {
                throw new SaldoIndisponivelException("Saldo Indisponível");
            }
            else
            {
                Saldo -= valor;
            }
        }



    }
}
