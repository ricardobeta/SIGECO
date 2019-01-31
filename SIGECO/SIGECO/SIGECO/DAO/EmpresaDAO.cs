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
    class EmpresaDAO
    {
        Conexion conexion;

        public EmpresaDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void agregarEmpresa(Representante r,Empresa empresa) {
            String insertarP = "INSERT INTO Personas  (nombre1,nombre2,apellido1,apellido2,cedula,pais,correo,telefono) " +
                "Values ('"+r.nombre1+ "','" + r.nombre2 + "','" + r.apellido1 + "','" + r.apellido2 + "'," +
                "'" + r.cedula + "','" + r.pais + "','" + r.correo + "','" + r.telefono + "')";
         
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
            String insertarR= "INSERT INTO Personas_Representante (id) Values(" + idPersona + ")";
            conexion.CerrarConexion();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = insertarR;
            myCommand.ExecuteNonQuery();

            String insertarC = "INSERT INTO EMPRESAS (nombre,ruc,Representante_id) Values('"+empresa.nombre+"','"+empresa.ruc+ "'," + idPersona + ")";
            conexion.CerrarConexion();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = insertarC;
            myCommand.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public Empresa consultarEmpresa(Empresa cliente, String cedula) {
            String consultaC = "Select * from Personas p , Empresas e  where p.Id = e.Representante_Id and e.ruc = '"+cedula+"'";
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = consultaC;
            SqlDataReader dr = myCommand.ExecuteReader();
            if (dr.Read())
            {
                cliente.Representante.Id = Convert.ToInt32(dr[0]);
                cliente.Representante.nombre1 = Convert.ToString(dr[1]);
                cliente.Representante.nombre2 = Convert.ToString(dr[2]);
                cliente.Representante.apellido1 = Convert.ToString(dr[3]);
                cliente.Representante.apellido2 = Convert.ToString(dr[4]);
                cliente.Representante.cedula = Convert.ToString(dr[5]);
                cliente.Representante.pais = Convert.ToString(dr[6]);
                cliente.Representante.correo = Convert.ToString(dr[7]);
                cliente.Representante.telefono = Convert.ToString(dr[8]);
                cliente.Id = Convert.ToInt32(dr[9]);
                cliente.nombre = Convert.ToString(dr[10]);
                cliente.ruc  = Convert.ToString(dr[11]);
            }
            conexion.CerrarConexion();
            return cliente;
        }


        public DataTable consultaClientes(DataTable dt, String cedula,bool bandera) {
            if (bandera == false)
            {
                String consultaCs = "Select nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono, nombre as nombreEmpresa, ruc as RUCEmpresa  from Personas p , Empresas e  where p.Id = e.Representante_Id";
                SqlDataAdapter da = new SqlDataAdapter(consultaCs, conexion.Iniciarconexion());
                da.Fill(dt);
                return dt;
            }
            else {
                String consultaCs = "Select nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono, nombre as nombreEmpresa, ruc as RUCEmpresa from Personas p , Empresas e  where p.Id = e.Representante_Id and e.ruc = '" + cedula+"'";
                SqlDataAdapter da = new SqlDataAdapter(consultaCs, conexion.Iniciarconexion());
                da.Fill(dt);
                return dt;

            }

        }


        public void modificarEmpresa(Empresa cliente) {

            String modificarP = "UPDATE PERSONAS SET nombre1 = '" + cliente.Representante.nombre1 + "', nombre2 = '" + cliente.Representante.nombre2 + "', apellido1 = '" + cliente.Representante.apellido1 +
                "', apellido2 = '" + cliente.Representante.apellido2 + "', cedula = '" + cliente.Representante.cedula + "', pais = '" + cliente.Representante.pais + "', correo = '" + cliente.Representante.correo + "', telefono = '" + cliente.Representante.telefono +
                "' WHERE id = '" + cliente.Representante.Id + "'";
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = modificarP;
            myCommand.ExecuteNonQuery();
            conexion.CerrarConexion();
            String modificarC = "UPDATE Empresas SET nombre = '" + cliente.nombre + "', ruc = '"+cliente.ruc+"' WHERE Id = '" + cliente.Id + "'";

            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = modificarC;
            myCommand.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void eliminarCliente(String cedula,String ruc) {
            //String eliminarE = "Delete Empresas where ruc  ='" + ruc + "'";
            SqlCommand myCommand = new SqlCommand();
            //myCommand.Connection = conexion.Iniciarconexion();
            //myCommand.CommandText = eliminarE;
            //myCommand.ExecuteNonQuery();
            //conexion.CerrarConexion();
            String eliminarP = "Delete Persona where cedula  ='"+cedula+"'";
            myCommand = new SqlCommand();
            myCommand.Connection = conexion.Iniciarconexion();
            myCommand.CommandText = eliminarP;
            myCommand.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


    }
}
