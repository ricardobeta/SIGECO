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
    public partial class VistaCobranzas : Form
    {
        public VistaCobranzas()
        {
            InitializeComponent();
        }

        private void bARetencion_Click(object sender, EventArgs e)
        {
            AgregarRetencion vista = new AgregarRetencion();
            vista.ShowDialog();
        }

        private void bAPago_Click(object sender, EventArgs e)
        {
            AgregarPago vista = new AgregarPago();
            vista.ShowDialog();
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
    }
}
