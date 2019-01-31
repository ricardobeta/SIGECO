namespace SIGECO.Vistas
{
    partial class RegistroRango
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.validarNombre2 = new System.Windows.Forms.Label();
            this.validarApellido = new System.Windows.Forms.Label();
            this.validarNombre = new System.Windows.Forms.Label();
            this.validarCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.lTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1289, 677);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(654, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 39);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(332, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(172, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.validarNombre2);
            this.groupBox2.Controls.Add(this.validarApellido);
            this.groupBox2.Controls.Add(this.validarNombre);
            this.groupBox2.Controls.Add(this.validarCedula);
            this.groupBox2.Controls.Add(this.textBoxCedula);
            this.groupBox2.Controls.Add(this.labelCedula);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.textBoxNombre2);
            this.groupBox2.Controls.Add(this.labelNombre2);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(95, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos principales";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // validarNombre2
            // 
            this.validarNombre2.AutoSize = true;
            this.validarNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre2.ForeColor = System.Drawing.Color.Red;
            this.validarNombre2.Location = new System.Drawing.Point(711, 108);
            this.validarNombre2.Name = "validarNombre2";
            this.validarNombre2.Size = new System.Drawing.Size(0, 17);
            this.validarNombre2.TabIndex = 29;
            // 
            // validarApellido
            // 
            this.validarApellido.AutoSize = true;
            this.validarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarApellido.ForeColor = System.Drawing.Color.Red;
            this.validarApellido.Location = new System.Drawing.Point(711, 137);
            this.validarApellido.Name = "validarApellido";
            this.validarApellido.Size = new System.Drawing.Size(0, 17);
            this.validarApellido.TabIndex = 28;
            // 
            // validarNombre
            // 
            this.validarNombre.AutoSize = true;
            this.validarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre.ForeColor = System.Drawing.Color.Red;
            this.validarNombre.Location = new System.Drawing.Point(711, 81);
            this.validarNombre.Name = "validarNombre";
            this.validarNombre.Size = new System.Drawing.Size(0, 17);
            this.validarNombre.TabIndex = 26;
            // 
            // validarCedula
            // 
            this.validarCedula.AutoSize = true;
            this.validarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarCedula.ForeColor = System.Drawing.Color.Red;
            this.validarCedula.Location = new System.Drawing.Point(711, 55);
            this.validarCedula.Name = "validarCedula";
            this.validarCedula.Size = new System.Drawing.Size(0, 17);
            this.validarCedula.TabIndex = 25;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCedula.AutoCompleteCustomSource.AddRange(new string[] {
            "1718029042"});
            this.textBoxCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCedula.Location = new System.Drawing.Point(406, 49);
            this.textBoxCedula.MaxLength = 10;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(199, 23);
            this.textBoxCedula.TabIndex = 1;
            this.textBoxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCedula_KeyPress);
            this.textBoxCedula.Leave += new System.EventHandler(this.textBoxCedula_Leave);
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelCedula.Location = new System.Drawing.Point(266, 49);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(134, 25);
            this.labelCedula.TabIndex = 22;
            this.labelCedula.Text = "Monto Inicial";
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(253, 132);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(147, 25);
            this.labelApellido.TabIndex = 20;
            this.labelApellido.Text = "Departamento";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(406, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre2.Location = new System.Drawing.Point(406, 105);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombre2.TabIndex = 3;
            this.textBoxNombre2.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // labelNombre2
            // 
            this.labelNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(164, 105);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(236, 25);
            this.labelNombre2.TabIndex = 19;
            this.labelNombre2.Text = "Porcentaje de comisión";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(275, 78);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(125, 25);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Monto Final";
            // 
            // lTitulo
            // 
            this.lTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(416, 9);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(492, 31);
            this.lTitulo.TabIndex = 5;
            this.lTitulo.Text = "REGISTRO DE RANGO";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 26);
            this.comboBox1.TabIndex = 32;
            // 
            // RegistroRango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1289, 677);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroRango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPersonaNatural";
            this.Load += new System.EventHandler(this.AgregarPersonaNatural_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label validarNombre2;
        private System.Windows.Forms.Label validarApellido;
        private System.Windows.Forms.Label validarNombre;
        private System.Windows.Forms.Label validarCedula;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}