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
    
    public partial class DetallePro
    {
        public int Id { get; set; }
        public int cantidad { get; set; }
        public int ProductoId { get; set; }
        public int FacturaId { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
