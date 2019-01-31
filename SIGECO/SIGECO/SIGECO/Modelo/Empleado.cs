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
    
    public partial class Empleado : Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]



        public Empleado()
        {
            this.Empleadoes = new HashSet<Empleado>();
            this.ComisionEmpleadoes = new HashSet<ComisionEmpleado>();
            this.PagoEmpleadoes = new HashSet<PagoEmpleado>();
            this.Operacions = new HashSet<Operacion>();



        }

        

        public double porcentajeComision { get; set; }
        public string cargo { get; set; }
        public decimal salarioActual { get; set; }
        public int EmpleadoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleadoes { get; set; }
        public virtual Empleado Empleado1 { get; set; }
        public virtual Venta Venta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComisionEmpleado> ComisionEmpleadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoEmpleado> PagoEmpleadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion> Operacions { get; set; }
    }
}
