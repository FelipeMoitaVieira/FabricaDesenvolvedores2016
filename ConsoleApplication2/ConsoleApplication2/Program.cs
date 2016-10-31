using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication2.models;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //*********************************************************************
            //***Questão 1 - Imprima todos os números entre 10 e 500.***
            //*********************************************************************


            for (int i = 10; i <= 500; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();


            //*********************************************************************
            // ***Questão 2 - Imprima a soma de 1 até 100***
            //*********************************************************************


            var soma = 0; var indice = 0;
            while (soma <= 100)
            {
                soma += indice;
                indice++;
                Console.WriteLine(soma);


            }

            Console.ReadLine();


            //*********************************************************************
            //****Questão 3 - Imprima todos os múltiplos de 3 entre 1 e 100.***
            //*********************************************************************


            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();


            //*********************************************************************
            //***4. Escreva um programa que leia um número inteiro (x) e calcule um novo valor para x, 
            //de acordo com a seguinte regra:
            //a.Se x for par, x = x / 2;
            //b.Se x for ímpar x = 7 * x + 1;
            //Imprima o valor de x, o programa deve parar quando x for igual a 1 ***
            //*********************************************************************


            int x = 0;

            while (x != 1)
            {
                Console.WriteLine("Digite um número: ");
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    x = x / 2;
                    Console.WriteLine(x);
                }
                else
                {
                    x = 7 * x + 1;
                    Console.WriteLine(x);
                }

            }



            //*********************************************************************
            //***5. Escreva um programa que solicite ao usuário o número de horas trabalhadas e o valor da hora de trabalho.***
            //Mostre o salário a ser pago em função das horas trabalhadas.
            //*********************************************************************



            Console.WriteLine("Programa de Calcular o sálario em função das horas Trabalhadas");

            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            double horaTrabalhada = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Hora Trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine());

            decimal salario = (decimal)(valorHora * horaTrabalhada);
            Console.WriteLine("Salário: " + salario);


            //*********************************************************************
            //***6. Um Banco concederá um crédito especial aos seus clientes, variável com o saldo médio no último ano.
            //Faça um algoritmo que leia o saldo médio de um cliente e calcule o valor do crédito de acordo com a tabela abaixo. 
            //Mostre uma mensagem informando o saldo médio e o valor do crédito.***
            //*********************************************************************


            Console.WriteLine("Programa que calcula Crédito Adicional para Clientes do Banco");
            Console.Write("Informe o valor médio de saldo em Conta Corrente no Último ano: ");
            decimal mediaSaldo = decimal.Parse(Console.ReadLine());

            if (mediaSaldo > 0 && mediaSaldo <= 200)
            {
                decimal credito = 0;
                Console.WriteLine("O saldo médio do Cliente é: " + mediaSaldo + " - Crédito: " + credito);
            }
            else if (mediaSaldo <= 400)
            {
                decimal credito = mediaSaldo * 0.2m;
                Console.WriteLine("O saldo médio do Cliente é: R$" + mediaSaldo + " - Crédito: R$" + credito);
            }
            else if (mediaSaldo <= 600)
            {
                decimal credito = mediaSaldo * 0.3m;
                Console.WriteLine("O saldo médio do Cliente é: R$" + mediaSaldo + " - Crédito: R$" + credito);
            }
            else
            {
                decimal credito = mediaSaldo * 0.4m;
                Console.WriteLine("O saldo médio do Cliente é: R$" + mediaSaldo + " - Crédito: R$" + credito);
            }


            //*********************************************************************
            //***7.Um vendedor necessita de um programa que calcule o preço total***
            //devido por um cliente. O programa deve receber o código de um
            //produto e a quantidade comprada.O programa deve calcular o
            //preço total, usando a tabela abaixo. Mostre uma mensagem no caso
            //de código inválido. 
            //*********************************************************************

            Console.WriteLine("Programa que Calcula valor devido por Cliente");

            Console.Write("Digite o Código do Produto:");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 1001 && codigo != 1324 && codigo != 6548 && codigo != 987 && codigo != 7623)
            {
                Console.WriteLine("Código de Produto inválido. Digite Novamente: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite a quantidade comprada: ");
            int qtdComprada = int.Parse(Console.ReadLine());

            var total = 0m;
            switch (codigo)
            {

                case 1001:
                    total = qtdComprada * 51.32m;
                    Console.WriteLine("Total: R$" + total);
                    break;

                case 1324:
                    total = qtdComprada * 16.45m;
                    Console.WriteLine("Total: R$" + total);
                    break;

                case 6548:
                    total = qtdComprada * 12.37m;
                    Console.WriteLine("Total: R$" + total);
                    break;

                case 987:
                    total = qtdComprada * 15.32m;
                    Console.WriteLine("Total: R$" + total);
                    break;

                case 7623:
                    total = qtdComprada * 6.45m;
                    Console.WriteLine("Total: R$" + total);
                    break;
            }


            //*********************************************************************
            //8. Em uma eleição presidencial existem cinco candidatos. Os votos são
            //informados através de códigos. Os dados utilizados para a contagem
            //dos votos obedecem à seguinte codificação:
            //- 1,2,3,4,5 = voto para os respectivos candidatos;
            //- 6 = voto nulo;
            //- 7 = voto em branco;
            //Elabore um algoritmo que leia o código do candidato em um voto.
            //Calcule e escreva:
            //- total de votos para cada candidato;
            //- total de votos nulos;
            //- total de votos em branco;
            //Como finalizador do conjunto de votos, tem - se o valor 0
            //*********************************************************************

            int resp = 1;
            int cdto1 = 0, cdto2 = 0, cdto3 = 0, cdto4 = 0, cdto5 = 0, nulo = 0, branco = 0;


            Console.WriteLine("Programa que Contabiliza Votos para Eleição Presidencial");
            while (resp != 0)
            {
                Console.Write("\n\nCANDIDADOS: \n 1 - Candidato 1 \n 2 - Candidato 2 \n 3 - Candidato 3 \n" +
                    " 4 - Candidato 4 \n 5 - Candidato 5 \n 6 - Voto NULO \n 7 - Voto em BRANCO \n Digite o seu Voto: ");
                resp = int.Parse(Console.ReadLine());
                while (resp < 0 || resp > 7)
                {
                    Console.WriteLine("\nOpção Inválida. Digite Novamente!");
                    Console.Write("\nCANDIDADOS: \n 1 - Candidato 1 \n 2 - Candidato 2 \n 3 - Candidato 3 \n" +
                   " 4 - Candidato 4 \n 5 - Candidato 5 \n 6 - Voto NULO \n 7 - Voto em BRANCO\n");
                    resp = int.Parse(Console.ReadLine());
                }

                switch (resp)
                {
                    case 1:
                        cdto1++;
                        break;
                    case 2:
                        cdto2++;
                        break;
                    case 3:
                        cdto3++;
                        break;
                    case 4:
                        cdto4++;
                        break;
                    case 5:
                        cdto5++;
                        break;
                    case 6:
                        nulo++;
                        break;
                    case 7:
                        branco++;
                        break;

                }

            }

            Console.WriteLine("CANDIDADO: \t\t VOTOS:  \n 1 - Candidato 1 \t" + cdto1 +
                                                "\n 2 - Candidato 2 \t" + cdto2 +
                                                "\n 3 - Candidato 3 \t" + cdto3 +
                                                "\n 4 - Candidato 4 \t" + cdto4 +
                                                "\n 5 - Candidato 5 \t" + cdto5 +
                                                "\n 6 - Voto NULO   \t" + nulo +
                                                "\n 7 - Voto em BRANCO \t" + branco);


            //*********************************************************************
            //9.Escreva um programa que solicite ao usuário 3(três) produtos, seu
            //nome, suas respectivas quantidades, preços e descontos (se em
            //oferta). Crie uma classe para armazenar essas informações.Mostre
            //no final valor total a ser pago e os respectivos produtos.
            //*********************************************************************


            List<Produto> listaProd = new List<Produto>();
            decimal total1 = 0;
            for (int i = 0; i < 3; i++)
            {
                var produto = new Produto();
                Console.Write("\nDigite o nome do Produto: ");
                produto.nome = Console.ReadLine();

                Console.Write("Digite a Quantidade: ");
                produto.quantidade = int.Parse(Console.ReadLine());

                Console.Write("Digite o preço: ");
                produto.preco = decimal.Parse(Console.ReadLine());

                Console.Write("Digite o desconto: ");
                produto.desconto = decimal.Parse(Console.ReadLine()) / 100;

                listaProd.Add(produto);

            }

            Console.WriteLine("\nResumo da Compra: \n");

            foreach (var prod in listaProd)
            {
                Console.WriteLine("Produto: " + prod.nome);
                total1 += (prod.quantidade * prod.preco) * (1 - prod.desconto);
            }

            Console.WriteLine("\nTotal com Desconto: R$" + total1);

            //*********************************************************************
            //10.Escreva um programa que exiba os seguintes padrões, utilizando o
            //controle de fluxo(repetição).
            //*********************************************************************
            StringBuilder des = new StringBuilder();
            //a.
            for (int i = 0; i < 10; i++)
            {
                des.Insert(i,"*");
                Console.WriteLine(des);
            }

            //b.
            StringBuilder des1 = new StringBuilder("**********");
            Console.WriteLine(des1);
            for (int i = 9; i >= 0; i--)
            {

                des.Remove(i, 1);
                Console.WriteLine(des);
            }

            //c.
            StringBuilder des2 = new StringBuilder("**********");
            Console.WriteLine(des2);
            for (int i = 0; i < 10; i++)
            {

                des2.Replace("*"," ",i,1);
                Console.WriteLine(des2);
            }

            //d.
            StringBuilder des3 = new StringBuilder("          ");
            
            for (int i = 9; i >= 0; i--)
            {

                des3.Replace(" ", "*", i, 1);
                Console.WriteLine(des3);
            }



        }
    }
}
