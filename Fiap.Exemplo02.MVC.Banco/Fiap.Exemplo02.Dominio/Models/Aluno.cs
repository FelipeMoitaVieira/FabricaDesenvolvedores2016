//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fiap.Exemplo02.Dominio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aluno()
        {
            this.Professor = new HashSet<Professor>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public bool Bolsa { get; set; }
        public Nullable<double> Desconto { get; set; }
        public Nullable<int> GrupoId { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professor { get; set; }
    }
}
