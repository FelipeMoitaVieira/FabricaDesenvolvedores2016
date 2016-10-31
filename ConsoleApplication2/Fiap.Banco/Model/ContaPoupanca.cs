using Fiap.Banco.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public class ContaPoupanca : Conta, IContaInvestimento
    {

        readonly decimal _rendimento;

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal Taxa { get; set; }


        public decimal CalculaRetornoInvestimento()
        {
            return (Saldo * _rendimento);
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if((Saldo - valor) > 0)
            {
                Saldo = Saldo - (valor * (1 + Taxa));
            }else
            {
                throw new SaldoIndisponivelException("Saldo Insuficiente");
            }
            
        }




    }
}
