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
            Application.Exit();
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
            AbrirFormulario<AgregarPersonaNatural>();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AgregarClienteEmpresa>();

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
