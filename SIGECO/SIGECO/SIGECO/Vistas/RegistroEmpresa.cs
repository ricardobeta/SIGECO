using SIGECO.Controlador;
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
    public partial class RegistroEmpresa : Form
    {
        ControlEmpresa controlEmpresa;
        public RegistroEmpresa()
        {
            InitializeComponent();
        }
        public RegistroEmpresa(String mod)
        {
            InitializeComponent();
            lTitulo.Text = mod;

        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
                       
            textBoxNombreE.Text = "";
            textBoxNombre.Text = "";
            textBoxNombre2.Text = "";
            textBoxApellido.Text = "";
            textBoxApellido2.Text = "";
            textBoxTelefono.Text = "";
            //textBoxRUC.Text = "";
            textBoxCorreo.Text = "";
            textBoxNombreE.Text = "";
            cbPais.SelectedItem = "";
            textBoxRucE.Text = "";
            textBoxNombreE.Text = "";
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlEmpresa = new ControlEmpresa();
            String nombre1 = textBoxNombre.Text, nombre2 = textBoxNombre2.Text, apellido1 = textBoxApellido.Text,
                apellido2 = textBoxApellido2.Text, cedula = textBoxCedula.Text, correo = textBoxCorreo.Text, telefono = textBoxTelefono.Text
                , rucE = textBoxRucE.Text, nombreE = textBoxNombreE.Text;
            if (vVacios(listatb()) && cbP())
            {
                String pais = cbPais.SelectedItem.ToString();
                controlEmpresa.agregarEmpresa(nombre1, nombre2, apellido1, apellido2, cedula, pais, correo, telefono, rucE, nombreE);
                MessageBox.Show("Cliente Registrado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Ingresar los datos");
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
            ltb.Add(textBoxNombreE);
            ltb.Add(textBoxRucE);
            ltb.Add(textBoxApellido2);
            ltb.Add(textBoxCedula);
            ltb.Add(textBoxTelefono);
            //ltb.Add(textBoxRUC);
            ltb.Add(textBoxCorreo);
            return ltb;
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

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {
            //Validar si ingreso 10 digitos de la cedula
            if (!textBoxCedula.Text.Length.Equals(10)) {

                validarCedula.Text = "Ingrese cédula de 10 Dígitos";
                btnRegistrar.Enabled = false;
            }
            else if (textBoxCedula.Text.Length.Equals(10))
            {
                validarCedula.Text = "";
                //Algoritmo de verificacion de cedula
                char[] cedula = textBoxCedula.Text.ToArray();
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
                    validarCedula.Text = "Número de cédula inválida";
                    btnRegistrar.Enabled = false;
                }

                else
                {
                    validarCedula.Text = "";
                    btnRegistrar.Enabled = true;
                }
            }
        }
    }
}
