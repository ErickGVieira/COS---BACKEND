//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cos.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdemDeServico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdemDeServico()
        {
            this.Orcamento = new HashSet<Orcamento>();
            this.Pagamento = new HashSet<Pagamento>();
        }
    
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idServicoSolicitado { get; set; }
        public int idServicoExecutado { get; set; }
        public int idStatus { get; set; }
        public System.DateTime dataInicio { get; set; }
        public Nullable<System.DateTime> dataFim { get; set; }
        public int idSolicitante { get; set; }
        public Nullable<int> idExecutor { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento> Orcamento { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Servico Servico1 { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagamento> Pagamento { get; set; }
    }
}
