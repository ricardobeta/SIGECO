//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGECO.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Retencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retencion()
        {
            this.DetalleRetencions = new HashSet<DetalleRetencion>();
        }
    
        public int Id { get; set; }
        public string numRetencion { get; set; }
        public double porcentaje { get; set; }
        public decimal valor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleRetencion> DetalleRetencions { get; set; }
    }
}