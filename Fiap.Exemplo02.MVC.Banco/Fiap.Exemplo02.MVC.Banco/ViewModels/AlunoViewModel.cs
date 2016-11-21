using Fiap.Exemplo02.MVC.Banco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Banco.ViewModels
{
    public class AlunoViewModel
    {
        //Opções do Select
        public SelectList ListaGrupo { get; set; }

        

        public string Mensagem { get; set; }

        #region Lista properties

        public ICollection<Aluno> Alunos { get; set; }

        public string NomeBusca { get; set; }

        public int? IdGrupo { get; set; }

        #endregion


        #region Aluno properties
        public int Id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Nome é Obrigatório")]
        public string Nome { get; set; }
        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public Nullable<double> Desconto { get; set; }
        public bool Bolsa { get; set; }
        [Display(Name ="Grupo")]
       
        public Nullable<int> GrupoId { get; set; }
       

        #endregion
    }
}
