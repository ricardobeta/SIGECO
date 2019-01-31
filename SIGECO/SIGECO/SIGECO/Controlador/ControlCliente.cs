
using SIGECO.DAO;
using SIGECO.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGECO.Controlador
{
    class ControlCliente
    {
        Cliente cliente;
        Conexion conexion;
        ClienteDAO clienteDAO;

        public void agregarCliente(string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais,
            string correo, string telefono, string ruc){
            cliente = new Cliente(0, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono, ruc);
            conexion = new Conexion();
            //conexion.Iniciarconexion();
            clienteDAO = new ClienteDAO(conexion);
            clienteDAO.agregarCliente(cliente);
        }

        public void eliminarCliente(String cedula) {
            conexion = new Conexion();
            clienteDAO = new ClienteDAO(conexion);
            clienteDAO.eliminarCliente(cedula);

        }


        public Cliente consultarClienteCedula(String cedula) {
            conexion = new Conexion();
            clienteDAO = new ClienteDAO(conexion);
            cliente = new Cliente();
            return cliente = clienteDAO.consultarCliente(cliente, cedula);                       
        }


        public DataTable consultaCliente(String cedula) {
            bool bandera = true;
            if (Comparer.Equals("", cedula)) bandera = false;

            conexion = new Conexion();
            clienteDAO = new ClienteDAO(conexion);
            DataTable dt = new DataTable();
            return clienteDAO.consultaClientes(dt,cedula,bandera);
        }

        public void modificarCliente(int id, string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais,
            string correo, string telefono, string ruc)
        {
            conexion = new Conexion();
            clienteDAO = new ClienteDAO(conexion);
            cliente = new Cliente(id, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono, ruc);
            clienteDAO.modificarCliente(cliente);
        }
    
    }
}
