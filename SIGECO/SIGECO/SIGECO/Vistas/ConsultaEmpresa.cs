using SIGECO.Controlador;
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
    public partial class ConsultaEmpresa : Form
    {
        ControlEmpresa controlEmpresa;
        public ConsultaEmpresa()
        {
            InitializeComponent();
            llenarCBTipocliente();

            controlEmpresa = new ControlEmpresa();
            tabla.DataSource = controlEmpresa.consultaEmpresa("");
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }

        private void llenarCBTipocliente()
        {


        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cedula = textBoxConsulta.Text;

            controlEmpresa= new ControlEmpresa();
            tabla.DataSource = controlEmpresa.consultaEmpresa(cedula);
        }
    }
}