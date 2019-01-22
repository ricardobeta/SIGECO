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
    public partial class AgregarClienteEmpresa : Form
    {
        public AgregarClienteEmpresa()
        {
            InitializeComponent();
        }

        public AgregarClienteEmpresa(String mod)
        {
            InitializeComponent();
            label1.Text = mod;

        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Esta seguro que desea cerrar el Formulario?", " Esta Cerrando el formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
