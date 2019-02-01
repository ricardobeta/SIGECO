using SIGECO.Controlador;
using SIGECO.Modelo;
using System;
using System.Collections;
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
    public partial class ModificacionOperacion : Form
    {
        ControlCliente controlCliente;
        int id;
        bool b;

        public ModificacionOperacion()
        {
            InitializeComponent();
            bloquea(false);

        }




        private void pCerrar_Click(object sender, EventArgs e)
        {
            textBoxConsulta.Text = "";
            textBoxNombre.Text = "";
            textBoxNombre2.Text = "";
            bloquea(false);

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            String cedula = textBoxConsulta.Text;
            controlCliente = new ControlCliente();
            Cliente cliente = controlCliente.consultarClienteCedula(cedula);
            

            if (!Comparer.Equals(cedula, "") && cliente != null && b)
            {

                textBoxNombre.Text = cliente.nombre1;
                textBoxNombre2.Text = cliente.nombre2;
                bloquea(true);
            }
            else
            {
                MessageBox.Show("La cedula ingresada es incorrecta");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bloquea(bool a)
        {
            textBoxNombre.Enabled = a;
            textBoxNombre2.Enabled = a;
        }
    }
}