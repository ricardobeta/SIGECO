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
    public partial class BuscarVentas : Form
    {
        public BuscarVentas()
        {
            InitializeComponent();
            llenarCBTipoFiltro();


        }

        private void llenarCBTipoFiltro()
        {
            cbTipoFiltro.Items.Add("");
            cbTipoFiltro.Items.Add("Fecha");
            cbTipoFiltro.Items.Add("Empleado");


        }

        private void cbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (cbTipoFiltro.SelectedIndex.ToString().CompareTo("1")==0) {
                lFechaInicio.Visible = true;
                dtFechaInicio.Visible = true;
                lFechaFin.Visible = true;
                dtFechaFin.Visible = true;
                bBuscarF.Visible = true;
                lCedula.Visible = false;
                txtCedulaCliente.Visible = false;
            } else if (cbTipoFiltro.SelectedIndex.ToString().CompareTo("2")==0)
            {
                lFechaInicio.Visible = false;
                dtFechaInicio.Visible =false;
                lFechaFin.Visible = false;
                dtFechaFin.Visible = false;
                bBuscarF.Visible = false;
                lCedula.Visible = true;
                txtCedulaCliente.Visible = true;
            }else
            {
                lFechaInicio.Visible = false;
                dtFechaInicio.Visible = false;
                lFechaFin.Visible = false;
                dtFechaFin.Visible = false;
                bBuscarF.Visible = false;
                lCedula.Visible = false;
                txtCedulaCliente.Visible = false;
            }
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
