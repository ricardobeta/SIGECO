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
    
    public partial class Cliente : Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Cliente() { }

        public Cliente(int id, string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais,
            string correo, string telefono, string ruc) : base(id, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono) => this.ruc = ruc;

        public string ruc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
