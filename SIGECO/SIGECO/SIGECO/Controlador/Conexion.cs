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
                    "Data Source=DESKTOP-OVI6PCV\\SQLEXPRESS;" +
                    "Initial Catalog=SIGECO4;" +
                    "Integrated Security = True;";
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

