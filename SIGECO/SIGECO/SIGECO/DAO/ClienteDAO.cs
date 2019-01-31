using SIGECO.Controlador;
using SIGECO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SIGECO.DAO
{
    class ClienteDAO
    {
        Conexion conexion;

        public ClienteDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void agregarCliente(Cliente cliente) {
            String insertarP = "INSERT INTO Personas  (nombre1,nombre2,apellido1,apellido2,cedula,pais,correo,telefono) " +
                "Values ('"+cliente.nombre1+ "','" + cliente.nombre2 + "','" + cliente.apellido1 + "','" + cliente.apellido2 + "'," +
                "'" + cliente.cedula + "','" + cliente.pais + "','" + cliente.correo + "','" + cliente.telefono + "')";
         
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = insertarP;
            myCommand.ExecuteNonQuery();
            String bp = "SELECT TOP 1 * FROM Personas ORDER BY ID DESC ";
            myCommand.CommandText = bp;
            SqlDataReader dr =myCommand.ExecuteReader();
            int idPersona=0;
            if (dr.Read()) {
                idPersona = Convert.ToInt32(dr[0]);
            }           
            String insertarC = "INSERT INTO Personas_Cliente (ruc,id) Values('"+cliente.ruc+"',"+idPersona+")";
            conexion.CerrarConexion();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = insertarC;
            myCommand.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public Cliente consultarCliente(Cliente cliente, String cedula) {
            String consultaC = "Select * from Personas, Personas_Cliente where " +
                "personas.id = Personas_Cliente.id and personas.cedula ='"+cedula+"'";
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = consultaC;
            SqlDataReader dr = myCommand.ExecuteReader();
            if (dr.Read())
            {
                cliente.Id = Convert.ToInt32(dr[0]);
                cliente.nombre1 = Convert.ToString(dr[1]);
                cliente.nombre2 = Convert.ToString(dr[2]);
                cliente.apellido1 = Convert.ToString(dr[3]);
                cliente.apellido2 = Convert.ToString(dr[4]);
                cliente.cedula = Convert.ToString(dr[5]);
                cliente.pais = Convert.ToString(dr[6]);
                cliente.correo = Convert.ToString(dr[7]);
                cliente.telefono = Convert.ToString(dr[8]);
                cliente.ruc = Convert.ToString(dr[9]);
            }
            conexion.CerrarConexion();
            return cliente;
        }


        public DataTable consultaClientes(DataTable dt) {
            String consultaCs = "Select * from  Personas_Cliente  c , Personas p where p.Id = c.Id";
            SqlDataAdapter da = new SqlDataAdapter(consultaCs,conexion.Iniciarconexion());
            da.Fill(dt);
            return dt;
        }


    }
}
