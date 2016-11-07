using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio03.Models
{
    public class Produto
    {

        public int ProdutoId { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Display(Name ="Título")]
        public string Titulo { get; set; }
        [Display(Name="Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }
        public bool Nacional { get; set; }

    }
}