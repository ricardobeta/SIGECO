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
    public partial class EliminacionClienteNatural : Form
    {

        ControlCliente controlCliente;
        public EliminacionClienteNatural()
        {
            InitializeComponent();
            controlCliente = new ControlCliente();
            tabla.DataSource = controlCliente.consultaCliente("");
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }

        

        private void pCerrar_Click(object sender, EventArgs e)
        {
            controlCliente = new ControlCliente();
            textBoxConsulta.Text = "";
            tabla.DataSource = controlCliente.consultaCliente("");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String cedula = textBoxConsulta.Text;
            controlCliente = new ControlCliente();
            tabla.DataSource = controlCliente.consultaCliente(cedula);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            controlCliente = new ControlCliente();
            try { String cedula = tabla.SelectedCells[0].Value.ToString();
                controlCliente.eliminarCliente(cedula);
                MessageBox.Show("Cliente Eliminado Exitosamente");
                this.Close();
            }
            catch {
                MessageBox.Show("Elija un Cliente");
            }

            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}