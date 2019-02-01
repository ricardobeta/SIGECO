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
    public partial class ModificacionDepartamento : Form
    {
        ControlCliente controlCliente;
        int id;
        bool b;

        public ModificacionDepartamento()
        {
            InitializeComponent();
            bloquea(false);

        }




        private void pCerrar_Click(object sender, EventArgs e)
        {
            textBoxConsulta.Text = "";
            textBoxNombre.Text = "";
            bloquea(false);

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

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
        }

        private bool vVacios(List<TextBox> ltb)
        {
            bool aux = true;
            for (int i = 0; i < ltb.Count; i++)
            {
                if (Comparer.Equals(ltb[i].Text, ""))
                {
                    ltb[i].BackColor = Color.Red;
                    aux = false;
                }
            }
            return aux;
        }
    }
}