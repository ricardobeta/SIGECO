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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
            llenarCBTipocliente();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (cbTipoCliente.SelectedIndex.ToString().CompareTo("1") == 0)
            {
                String mod = "Modificar Cliente Persona Natural";
                RegistroDeClienteNatural vista = new RegistroDeClienteNatural(mod);
                vista.ShowDialog();
            }
            else if (cbTipoCliente.SelectedIndex.ToString().CompareTo("2") == 0) {

                String mod = "Modificar Cliente Empresa";
                AgregarClienteEmpresa vista = new AgregarClienteEmpresa(mod);
                vista.ShowDialog();

            }
        }

        private void llenarCBTipocliente()
        {
            cbTipoCliente.Items.Add("");       
            cbTipoCliente.Items.Add("Persona Natural");
            cbTipoCliente.Items.Add("Empresa");
            

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
