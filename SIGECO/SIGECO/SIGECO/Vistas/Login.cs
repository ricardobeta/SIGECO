﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {
            /*String user = txtUser.Text;
            MessageBox.Show("Bienvenido "+user, " Ingreso satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            Principal vista = new Principal();
            vista.Show();
            this.Hide();
        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Esta seguro que desea cerrar la Aplicación?", " Esta Cerrando la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
