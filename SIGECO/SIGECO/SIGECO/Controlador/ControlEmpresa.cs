
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
    class ControlEmpresa
    {
        Representante cliente;
        Conexion conexion;        
        Representante representante;
        EmpresaDAO empresaDAO;
        Empresa empresa;

        public void agregarEmpresa(string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais,
            string correo, string telefono, string rucE, string nombreE){
            cliente = new Representante(0, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono);
            empresa = new Empresa(0, nombreE, rucE);
            conexion = new Conexion();
            representante = new Representante(0, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono);
            
            empresaDAO = new EmpresaDAO(conexion);
            empresaDAO.agregarEmpresa(representante,empresa);
           
           
            
        }

        public void eliminarCliente(string cedula, string ruc) {
            conexion = new Conexion();
            empresaDAO = new EmpresaDAO(conexion);
            empresaDAO.eliminarCliente(cedula,ruc);

        }


        public Empresa consultarClienteCedula(String cedula) {
            conexion = new Conexion();
            empresaDAO = new EmpresaDAO(conexion);
            representante = new Representante();
            empresa = new Empresa();
            empresa.Representante = new Representante();
            return empresa = empresaDAO.consultarEmpresa(empresa, cedula);                       
        }


        public DataTable consultaEmpresa(String cedula) {
            bool bandera = true;
            if (Comparer.Equals("", cedula)) bandera = false;

            conexion = new Conexion();
            empresaDAO = new EmpresaDAO(conexion);
            DataTable dt = new DataTable();
            return empresaDAO.consultaClientes(dt,cedula,bandera);
        }

        public void modificarEmpresa(int id,int idE,string nombreE,string rucE, string nombre1, string nombre2, string apellido1, string apellido2, string cedula, string pais,
            string correo, string telefono)
        {
            conexion = new Conexion();
            empresaDAO = new EmpresaDAO(conexion);
            representante = new Representante(id, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono);
            empresa = new Empresa(idE,nombreE,rucE,representante);
            empresaDAO.modificarEmpresa(empresa);
           //clienteDAO.modificarCliente(cliente);
        }
    
    }
}
