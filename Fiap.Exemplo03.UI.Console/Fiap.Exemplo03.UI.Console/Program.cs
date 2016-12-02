using Fiap.Exemplo03.UI.Console.DTOs;
using Fiap.Exemplo03.UI.Console.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo03.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 1;

            while (resp != 2)
            {

                System.Console.WriteLine("Programa que Consome a API da Fábrica de Desenvolvedores 2016");
                System.Console.WriteLine("Lista de Ações: \n 0 - Cadastrar Aluno \n 1 - Listar Alunos \n 2 - Sair");
                resp = Convert.ToInt32(System.Console.ReadLine());
                while (resp < 0 && resp > 2)
                {
                    System.Console.WriteLine("Opção Inválida! Digite Novamente!");
                    resp = Convert.ToInt32(System.Console.ReadLine());
                }
                var repo = new Repository();
                switch (resp)
                {
                    case 0:

                        System.Console.WriteLine("Informe o Nome do Aluno:");
                        var nome = System.Console.ReadLine();
                        System.Console.WriteLine("Informe SIM ou NÃO - Possui Bolsa?");
                        var bolsa = System.Console.ReadLine();
                        if (bolsa.StartsWith("S"))
                        {
                            bolsa = "true";
                        }
                        else if (bolsa.StartsWith("N"))
                        {
                            bolsa = "false";
                        }
                        System.Console.WriteLine("Caso Possua, qual o Desconto?");
                        var desconto = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Informe o Código do Grupo");
                        var idGrupo = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Informe a Data de Nascimento");
                        var dataNascimento = DateTime.Parse(System.Console.ReadLine());

                        var aluno = new AlunoDTO()
                        {
                            Nome = nome,
                            Bolsa = bool.Parse(bolsa),
                            Desconto = desconto,
                            GrupoId = idGrupo,
                            DataNascimento = dataNascimento
                        };

                        repo.AlunoPost(aluno);

                        break;
                    case 1:
                        IEnumerable<AlunoDTO> lista = repo.AlunoGet();
                        foreach (var a in lista)
                        {
                            System.Console.WriteLine("Nome: " + a.Nome);
                            System.Console.WriteLine("ID: " + a.Id);
                            System.Console.WriteLine("Data de Nascimento: " + a.DataNascimento);
                            System.Console.WriteLine("Possui Bolsa: " + a.Bolsa);
                            System.Console.WriteLine("Desconto: R$" + a.Desconto);
                            System.Console.WriteLine("ID Grupo: " + a.GrupoId);
                        }
                        System.Console.ReadLine();

                        break;
                    case 2:

                        break;

                }



            }    
            
            
                
            
        }
    }
}
