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
    public partial class EliminacionEmpresa : Form
    {
        ControlEmpresa controlEmpresa;

        public EliminacionEmpresa()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            controlEmpresa= new ControlEmpresa();
            try
            {
                String cedula = tabla.SelectedCells[0].Value.ToString();
                String  ruc = tabla.SelectedCells[0].Value.ToString();
                controlEmpresa.eliminarCliente(cedula,ruc);
                MessageBox.Show("Cliente Eliminado Exitosamente");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Elija un Cliente");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String cedula = textBoxConsulta.Text;
            controlEmpresa= new ControlEmpresa();
            tabla.DataSource = controlEmpresa.consultaEmpresa(cedula);
        }
    }
    }
