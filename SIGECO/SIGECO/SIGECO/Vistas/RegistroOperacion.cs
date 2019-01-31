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
    public partial class RegistroOperacion : Form
    {
        ControlCliente controlCLiente;

        public RegistroOperacion()
        {
            InitializeComponent();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarPersonaNatural_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sIGECODataSet.Pais' table. You can move, or remove it, as needed.
            try
            {
                //this.paisTableAdapter.Fill(this.sIGECODataSet.Pais);
            }
            catch (Exception)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!textBoxNombre.Text.Equals(""))
            {
                textBoxNombre.Text = textBoxNombre.Text.ToLower();
                String primeraLetra = textBoxNombre.Text.Substring(0, 1).ToUpper();
                String nombreRestante = textBoxNombre.Text.Substring(1, textBoxNombre.Text.Length - 1).ToLower();
                textBoxNombre.Text = primeraLetra + nombreRestante;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!textBoxNombre2.Text.Equals(""))
            {
                textBoxNombre2.Text = textBoxNombre2.Text.ToLower();
                String primeraLetra = textBoxNombre2.Text.Substring(0, 1).ToUpper();
                String nombreRestante = textBoxNombre2.Text.Substring(1, textBoxNombre2.Text.Length - 1).ToLower();
                textBoxNombre2.Text = primeraLetra + nombreRestante;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
