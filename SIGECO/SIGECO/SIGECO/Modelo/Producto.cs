using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGECO.Modelo
{
    class Producto
    {
        int codigo;
        private String nombre, descripcion;
        private double precio;

        public Producto(int codigo, String nombre, String descripcion, double precio) {
            this.Codigo = codigo;
            this.nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio=precio;
            
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
