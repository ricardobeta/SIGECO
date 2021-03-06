﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIGECO.Vistas
{
    public partial class Principal : Form
    {
        Form formulario;
        internal static int  p = 1;
        public Principal()
        {
            InitializeComponent();
            menuPrincipal.Renderer = new MiRenderizador();
        }

// ESTE CODIGO ES PARA EDITAR  EL BACKGROUND DEL MENU
        private class MiRenderizador : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                else
                {
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(Brushes.DimGray, rc); //Elige el color que desees
                    e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                }
            }
        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Esta seguro en cerrar la Aplicación?"," Esta Cerrando la aplicación",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
                Application.Exit();
            }
            
        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void bMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pRestaurar_Click(object sender, EventArgs e)
        {
            pMaximizar.Visible = true;
            pRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void personaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroClienteNatural>();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarEmpleado>();   
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarProducto>();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AgregarVenta>();
        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuscarEmpleado>();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuscarProductos>();
        }

        private void buscarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuscarVentas>();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VistaComisionesEmpleados>();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VistaComisionesVenta>();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VistaCobranzas>();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "archivo.pdf");

            Process.Start(pdfPath);
        }

        private void informaciónDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("La aplicación SIGECO se encuentra en su prototipo 1", " Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuscarEmpleado>();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroClienteNatural>();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroDeEmpresa>();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaClienteNatural>();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaClienteNatural>();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ModificacionClienteNatural>();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminacionClienteNatural>();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ModificacionClienteNatural>();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminacionClienteNatural>();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroEmpleado>();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaEmpleado>();
        }

        private void registrarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroUsuario>();
        }

        private void modificarToolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListaDepartamento>();
        }

        private void registrarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroDepartamento>();
        }

        private void registrarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroOperacion>();
        }

        private void consultarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaOperacion>();
        }

        private void registrarToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroRango>();
        }

        private void registrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistroCobro>();
        }

        private void pMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            pMaximizar.Visible = false;
            pRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            
            formulario = contenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                contenedor.Controls.Add(formulario);                
                contenedor.Tag = formulario;                
                formulario.Show();
                formulario.BringToFront();                
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
                
            }


        }

       


    }
}
