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
    
    public partial class Persona
    {
        public Persona()
        {
        }

        public Persona(int id, string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais, string correo, string telefono)
        {
            Id = id;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.cedula = cedula;
            this.pais = pais;
            this.correo = correo;
            this.telefono = telefono;
        }

        public int Id { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string cedula { get; set; }
        public string pais { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }


    }
}
