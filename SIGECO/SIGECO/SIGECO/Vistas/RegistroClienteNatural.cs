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
    public partial class RegistroClienteNatural : Form
    {
        public RegistroClienteNatural()
        {
            InitializeComponent();
        }
        public RegistroClienteNatural(String mod)
        {
            InitializeComponent();
            lTitulo.Text = mod;

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {
            //Validar si ingreso 10 digitos de la cedula
            if (!textBoxCedula.Text.Length.Equals(10))
                validarCedula.Text = "Ingrese cédula de 10 Dígitos";

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
                    validarCedula.Text = "Número de cédula inválida";
                else
                {
                    validarCedula.Text = "";
                }
            }
               
            
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
            if(!textBoxNombre2.Text.Equals(""))
            {
                textBoxNombre2.Text = textBoxNombre2.Text.ToLower();
                String primeraLetra = textBoxNombre2.Text.Substring(0, 1).ToUpper();
                String nombreRestante = textBoxNombre2.Text.Substring(1, textBoxNombre2.Text.Length - 1).ToLower();
                textBoxNombre2.Text = primeraLetra + nombreRestante;
            }
           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(!textBoxApellido.Text.Equals(""))
            {
                textBoxApellido.Text = textBoxApellido.Text.ToLower();
                String primeraLetra = textBoxApellido.Text.Substring(0, 1).ToUpper();
                String nombreRestante = textBoxApellido.Text.Substring(1, textBoxApellido.Text.Length - 1).ToLower();
                textBoxApellido.Text = primeraLetra + nombreRestante;
            }
           
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!textBoxApellido2.Text.Equals(""))
            {
                textBoxApellido2.Text = textBoxApellido2.Text.ToLower();
                String primeraLetra = textBoxApellido2.Text.Substring(0, 1).ToUpper();
                String nombreRestante = textBoxApellido2.Text.Substring(1, textBoxApellido2.Text.Length - 1).ToLower();
                textBoxApellido2.Text = primeraLetra + nombreRestante;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (!textBox8Correo.Text.Equals(""))
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(textBox8Correo.Text);
                    validarCorreo.Text = "";
                }
                catch (FormatException)
                {
                    validarCorreo.Text = "Correo Inválido";
                }
            }

        }

        private void textBox6RUC_Enter(object sender, EventArgs e)
        {
            textBox6RUC.Text = textBoxCedula.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCedula.Text.Equals("") && validarCorreo.Text.Equals(""))
            {
                /*
                 */ 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
