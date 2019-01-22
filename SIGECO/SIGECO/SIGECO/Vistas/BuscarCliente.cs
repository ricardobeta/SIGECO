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

        }

        private void llenarCBTipocliente()
        {
            cbTipoCliente.Items.Add("");       
            cbTipoCliente.Items.Add("Persona Natural");
            cbTipoCliente.Items.Add("Empresa");
            

        }
    }
}
