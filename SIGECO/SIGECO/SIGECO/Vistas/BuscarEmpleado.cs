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
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
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

        private void bModificar_Click(object sender, EventArgs e)
        {
            string mod = "Modificar Empleado";
            RegistrarEmpleado vista = new RegistrarEmpleado(mod);
            vista.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPagoEmpleado vista = new AgregarPagoEmpleado();
            vista.ShowDialog();

        }
    }
}
