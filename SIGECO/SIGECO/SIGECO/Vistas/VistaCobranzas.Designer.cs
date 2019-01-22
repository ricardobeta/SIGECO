namespace SIGECO.Vistas
{
    partial class VistaCobranzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCobranzas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBuscarF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bARetencion = new System.Windows.Forms.Button();
            this.bAPago = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pCerrar);
            this.panel1.Controls.Add(this.bBuscarF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lFechaFin);
            this.panel1.Controls.Add(this.lFechaInicio);
            this.panel1.Controls.Add(this.dtFechaFin);
            this.panel1.Controls.Add(this.dtFechaInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 0;
            // 
            // bBuscarF
            // 
            this.bBuscarF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bBuscarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bBuscarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarF.ForeColor = System.Drawing.Color.White;
            this.bBuscarF.Location = new System.Drawing.Point(829, 49);
            this.bBuscarF.Name = "bBuscarF";
            this.bBuscarF.Size = new System.Drawing.Size(70, 29);
            this.bBuscarF.TabIndex = 74;
            this.bBuscarF.Text = "Buscar";
            this.bBuscarF.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cobranzas";
            // 
            // lFechaFin
            // 
            this.lFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaFin.Location = new System.Drawing.Point(537, 60);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(80, 16);
            this.lFechaFin.TabIndex = 83;
            this.lFechaFin.Text = "Fecha Fin:";
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaInicio.Location = new System.Drawing.Point(170, 60);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(96, 16);
            this.lFechaInicio.TabIndex = 82;
            this.lFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFechaFin.Location = new System.Drawing.Point(623, 57);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFin.TabIndex = 81;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFechaInicio.Location = new System.Drawing.Point(275, 58);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicio.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bARetencion);
            this.panel2.Controls.Add(this.bAPago);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 50);
            this.panel2.TabIndex = 2;
            // 
            // bARetencion
            // 
            this.bARetencion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bARetencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bARetencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bARetencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bARetencion.ForeColor = System.Drawing.Color.White;
            this.bARetencion.Location = new System.Drawing.Point(385, 6);
            this.bARetencion.Name = "bARetencion";
            this.bARetencion.Size = new System.Drawing.Size(200, 40);
            this.bARetencion.TabIndex = 26;
            this.bARetencion.Text = "Retenciones";
            this.bARetencion.UseVisualStyleBackColor = false;
            this.bARetencion.Click += new System.EventHandler(this.bARetencion_Click);
            // 
            // bAPago
            // 
            this.bAPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bAPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bAPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAPago.ForeColor = System.Drawing.Color.White;
            this.bAPago.Location = new System.Drawing.Point(591, 6);
            this.bAPago.Name = "bAPago";
            this.bAPago.Size = new System.Drawing.Size(200, 40);
            this.bAPago.TabIndex = 25;
            this.bAPago.Text = "Pagos";
            this.bAPago.UseVisualStyleBackColor = false;
            this.bAPago.Click += new System.EventHandler(this.bAPago_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1200, 420);
            this.dataGridView1.TabIndex = 3;
            // 
            // pCerrar
            // 
            this.pCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.pCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pCerrar.Image")));
            this.pCerrar.Location = new System.Drawing.Point(1170, 0);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(30, 30);
            this.pCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pCerrar.TabIndex = 84;
            this.pCerrar.TabStop = false;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            // 
            // VistaCobranzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaCobranzas";
            this.Text = "VistaCobranzas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBuscarF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bARetencion;
        private System.Windows.Forms.Button bAPago;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pCerrar;
    }
}