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
    public partial class ModificacionEmpresa : Form
    {
        public ModificacionEmpresa()
        {
            InitializeComponent();
            llenarCBTipocliente();
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

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            String cedula = textBoxConsulta.Text;
            controlEmpresa = new ControlEmpresa();
            Empresa cliente = controlEmpresa.consultarClienteCedula(cedula);
           //vCedula(textBoxConsulta, validarConsulta);

            if (!Comparer.Equals(cedula, "") && cliente != null && b)
            {

                textBoxCedula.Text = cliente.Representante.cedula;
                textBoxNombre.Text = cliente.Representante.nombre1;
                textBoxNombre2.Text = cliente.Representante.nombre2;
                textBoxApellido.Text = cliente.Representante.apellido1;
                textBoxApellido2.Text = cliente.Representante.apellido2;
                textBoxTelefono.Text = cliente.Representante.telefono;
                textBoxRucE.Text = cliente.ruc;
                textBoxNombreE.Text = cliente.nombre;
                textBoxCorreo.Text = cliente.Representante.correo;
                cbPais.SelectedItem = cliente.Representante.pais;
                id = cliente.Representante.Id;
                idE = cliente.Id;
                bloquea(true);
            }
            else
            {
                MessageBox.Show("La cedula ingresada es incorrecta");
            }

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void bloquea(bool a)
        {
            textBoxCedula.Enabled = a;
            textBoxNombre.Enabled = a;
            textBoxNombre2.Enabled = a;
            textBoxApellido.Enabled = a;
            textBoxApellido2.Enabled = a;
            textBoxTelefono.Enabled = a;
            //textBoxRUC.Enabled = a;
            textBoxCorreo.Enabled = a;
            cbPais.Enabled = a;
        }


        private void vCedula(TextBox textBox, Label label)
        {
            validarCedula.Text = "";
            //Algoritmo de verificacion de cedula
            char[] cedula = textBox.Text.ToArray();
            int[] cedulaInt = new int[10];
            int numero = 0;
            //Convertir a Numeros Enteros y copiar al arreglo
            for (int i = 0; i < cedula.Length; i++)
            {
                cedulaInt[i] = Convert.ToInt32(cedula[i]) - 48;
            }
            //Multiplicar por 2 los digitos de posicion impar
            for (int i = 0; i < cedulaInt.Length - 1; i += 2)
            {
                cedulaInt[i] *= 2;
                //Restar 9 en caso de que el resultado sea mayor a 9
                if (cedulaInt[i] > 9)
                    cedulaInt[i] -= 9;
            }
            //Sumar todos los valores
            for (int i = 0; i < cedulaInt.Length; i++)
                numero += cedulaInt[i];
            //Verificar si el modulo 10 da 0
            if (!(numero % 10 == 0))
            {
                label.Text = "Número de cédula inválida";
                btnModificar.Enabled = false;
                b = false;
            }
            else
            {
                label.Text = "";
                btnModificar.Enabled = true;
                b = true;
            }


        }


        private bool cbP()
        {
            bool aux = true;
            if (cbPais.SelectedItem == null)
                aux = false;
            return aux;
        }
        private List<TextBox> listatb()
        {
            List<TextBox> ltb = new List<TextBox>();
            ltb.Add(textBoxNombre);
            ltb.Add(textBoxNombre2);
            ltb.Add(textBoxApellido);
            ltb.Add(textBoxApellido2);
            ltb.Add(textBoxCedula);
            ltb.Add(textBoxTelefono);
            //ltb.Add(textBoxRUC);
            ltb.Add(textBoxCorreo);
            return ltb;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlEmpresa = new ControlEmpresa();
            String nombre1 = textBoxNombre.Text, nombre2 = textBoxNombre2.Text, apellido1 = textBoxApellido.Text,
               apellido2 = textBoxApellido2.Text, cedula = textBoxCedula.Text, correo = textBoxCorreo.Text, telefono = textBoxTelefono.Text
               , rucE = textBoxRucE.Text, nombreE = textBoxNombreE.Text;
            if (vVacios(listatb()) && cbP())
            {
                String pais = cbPais.SelectedItem.ToString();
                controlEmpresa.modificarEmpresa(id, idE, nombreE, rucE, nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono);
                MessageBox.Show("Cliente Modificado Exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al Ingresar los datos");
            }
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