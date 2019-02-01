using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGECO.Controlador
{
    class Conexion
    {
        SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString =
                    "Data Source=WIN-UC841MR2LRQ\\SQLpub;" +
                    "Initial Catalog=nodo1;" +
                    "User id=sa;" +
                    "Password=@dminServer123;";
        }


        public SqlConnection Iniciarconexion()
        {
            this.conexion.Open();
            return conexion;
        }

        public void CerrarConexion()
        {
            this.conexion.Close();
            Console.WriteLine("Cierre de Conexion");
        }

    }

}

