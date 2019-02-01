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
    public partial class ModificacionUsuario : Form
    {
        ControlCliente controlCliente;
        int id;
        bool b;

        public ModificacionUsuario()
        {
            InitializeComponent();
            bloquea(false);

        }




        private void pCerrar_Click(object sender, EventArgs e)
        {
            textBoxConsulta.Text = "";
            textBoxCedula.Text = "";
            textBoxNombre.Text = "";
            textBoxNombre2.Text = "";
            id = 0;
            bloquea(false);

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            String cedula = textBoxConsulta.Text;
            controlCliente = new ControlCliente();
            Cliente cliente = controlCliente.consultarClienteCedula(cedula);
            vCedula(textBoxConsulta, validarConsulta);

            if (!Comparer.Equals(cedula, "") && cliente != null && b)
            {

                textBoxCedula.Text = cliente.cedula;
                textBoxNombre.Text = cliente.nombre1;
                textBoxNombre2.Text = cliente.nombre2;
                id = cliente.Id;
                bloquea(true);
            }
            else
            {
                MessageBox.Show("La cedula ingresada es incorrecta");
            }

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
            textBoxCedula.Enabled = a;
            textBoxNombre.Enabled = a;
            textBoxNombre2.Enabled = a;
        }

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {
            vCedula(textBoxCedula, validarCedula);
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


       
    }
}