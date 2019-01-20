namespace SIGECO.Vistas
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pMaximizar = new System.Windows.Forms.PictureBox();
            this.pCerrar = new System.Windows.Forms.PictureBox();
            this.bMinimizar = new System.Windows.Forms.PictureBox();
            this.bClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.bEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pRestaurar = new System.Windows.Forms.PictureBox();
            this.pagoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimizar)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // pMaximizar
            // 
            this.pMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pMaximizar.Image")));
            this.pMaximizar.Location = new System.Drawing.Point(1080, 12);
            this.pMaximizar.Name = "pMaximizar";
            this.pMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMaximizar.TabIndex = 4;
            this.pMaximizar.TabStop = false;
            this.pMaximizar.Click += new System.EventHandler(this.pMaximizar_Click);
            // 
            // pCerrar
            // 
            this.pCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pCerrar.Image")));
            this.pCerrar.Location = new System.Drawing.Point(1113, 12);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(25, 25);
            this.pCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCerrar.TabIndex = 3;
            this.pCerrar.TabStop = false;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            // 
            // bMinimizar
            // 
            this.bMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("bMinimizar.Image")));
            this.bMinimizar.Location = new System.Drawing.Point(1051, 14);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Size = new System.Drawing.Size(23, 23);
            this.bMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bMinimizar.TabIndex = 5;
            this.bMinimizar.TabStop = false;
            this.bMinimizar.Click += new System.EventHandler(this.bMinimizar_Click);
            // 
            // bClientes
            // 
            this.bClientes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bClientes.AutoSize = false;
            this.bClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.bClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.bClientes.Image = ((System.Drawing.Image)(resources.GetObject("bClientes.Image")));
            this.bClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bClientes.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.bClientes.MergeIndex = 0;
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(122, 52);
            this.bClientes.Text = "CLIENTES";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaNaturalToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.nuevoClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoClienteToolStripMenuItem.Image")));
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // personaNaturalToolStripMenuItem
            // 
            this.personaNaturalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personaNaturalToolStripMenuItem.Image")));
            this.personaNaturalToolStripMenuItem.Name = "personaNaturalToolStripMenuItem";
            this.personaNaturalToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.personaNaturalToolStripMenuItem.Text = "Persona Natural";
            this.personaNaturalToolStripMenuItem.Click += new System.EventHandler(this.personaNaturalToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AllowDrop = true;
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bClientes,
            this.bEmpleados,
            this.toolStripMenuItem1,
            this.toolStripMenuItem10,
            this.toolStripMenuItem8,
            this.toolStripMenuItem6,
            this.toolStripMenuItem4});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.Size = new System.Drawing.Size(1150, 50);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // bEmpleados
            // 
            this.bEmpleados.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bEmpleados.AutoSize = false;
            this.bEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.pagoEmpleadosToolStripMenuItem});
            this.bEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.bEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("bEmpleados.Image")));
            this.bEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bEmpleados.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.bEmpleados.MergeIndex = 0;
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(140, 52);
            this.bEmpleados.Text = "EMPLEADOS";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEmpleadoToolStripMenuItem,
            this.buscaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 26);
            this.toolStripMenuItem2.Text = "Empleados";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.toolStripMenuItem1.MergeIndex = 0;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 52);
            this.toolStripMenuItem1.Text = "PRODUCTOS";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItem3.Text = "Nuevo Producto";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem10.AutoSize = false;
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem10.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.toolStripMenuItem10.MergeIndex = 0;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(122, 52);
            this.toolStripMenuItem10.Text = "VENTAS";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(188, 30);
            this.toolStripMenuItem11.Text = "Nueva Venta";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem8.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.toolStripMenuItem8.MergeIndex = 0;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(140, 52);
            this.toolStripMenuItem8.Text = "COMISIONES";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.toolStripMenuItem6.MergeIndex = 0;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(140, 52);
            this.toolStripMenuItem6.Text = "COBRANZAS";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.toolStripMenuItem4.MergeIndex = 0;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 52);
            this.toolStripMenuItem4.Text = "ADMINISTRADOR";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Controls.Add(this.pLogo);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1150, 550);
            this.contenedor.TabIndex = 6;
            // 
            // pLogo
            // 
            this.pLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(333, 194);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(450, 159);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pLogo.TabIndex = 2;
            this.pLogo.TabStop = false;
            // 
            // pRestaurar
            // 
            this.pRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pRestaurar.Image")));
            this.pRestaurar.Location = new System.Drawing.Point(1080, 12);
            this.pRestaurar.Name = "pRestaurar";
            this.pRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRestaurar.TabIndex = 3;
            this.pRestaurar.TabStop = false;
            this.pRestaurar.Visible = false;
            this.pRestaurar.Click += new System.EventHandler(this.pRestaurar_Click);
            // 
            // pagoEmpleadosToolStripMenuItem
            // 
            this.pagoEmpleadosToolStripMenuItem.Name = "pagoEmpleadosToolStripMenuItem";
            this.pagoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.pagoEmpleadosToolStripMenuItem.Text = "Pago Empleados";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Registrar Empleado";
            this.nuevoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEmpleadoToolStripMenuItem_Click);
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.buscaToolStripMenuItem.Text = "Buscar Empleado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.pRestaurar);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.bMinimizar);
            this.Controls.Add(this.pMaximizar);
            this.Controls.Add(this.pCerrar);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            ((System.ComponentModel.ISupportInitialize)(this.pMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimizar)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pMaximizar;
        private System.Windows.Forms.PictureBox pCerrar;
        private System.Windows.Forms.PictureBox bMinimizar;
        private System.Windows.Forms.ToolStripMenuItem bClientes;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEmpleados;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pRestaurar;
        private System.Windows.Forms.ToolStripMenuItem personaNaturalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoEmpleadosToolStripMenuItem;
    }
}