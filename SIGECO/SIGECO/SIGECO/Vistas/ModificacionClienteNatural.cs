using SIGECO.Controlador;
using SIGECO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGECO.Vistas
{
    public partial class ModificacionClienteNatural : Form
    {
        ControlCliente controlCliente;

        public ModificacionClienteNatural()
        {
            InitializeComponent();
            
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }


        private void pCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            controlCliente = new ControlCliente();
            String cedula = textBoxConsulta.Text;
            Cliente cliente = controlCliente.consultarClienteCedula(cedula);
            textBoxCedula.Text = cliente.cedula;
            textBoxNombre.Text = cliente.nombre1;
            textBoxNombre2.Text = cliente.nombre2;
            textBoxApellido.Text = cliente.apellido1;
            textBoxApellido2.Text = cliente.apellido2;
            textBoxTelefono.Text = cliente.telefono;
            textBoxRUC.Text = cliente.ruc;
            textBoxCorreo.Text = cliente.correo;

        }
    }
}