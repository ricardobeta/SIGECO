﻿namespace SIGECO.Vistas
{
    partial class ModificacionVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.validarConsulta = new System.Windows.Forms.Label();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.validarNombre2 = new System.Windows.Forms.Label();
            this.validarApellido = new System.Windows.Forms.Label();
            this.validarNombre = new System.Windows.Forms.Label();
            this.validarCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.validarConsulta);
            this.panel1.Controls.Add(this.textBoxConsulta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lTitulo);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 548);
            this.panel1.TabIndex = 0;
            // 
            // validarConsulta
            // 
            this.validarConsulta.AutoSize = true;
            this.validarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarConsulta.ForeColor = System.Drawing.Color.Red;
            this.validarConsulta.Location = new System.Drawing.Point(899, 80);
            this.validarConsulta.Name = "validarConsulta";
            this.validarConsulta.Size = new System.Drawing.Size(0, 17);
            this.validarConsulta.TabIndex = 71;
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConsulta.AutoCompleteCustomSource.AddRange(new string[] {
            "1718029042"});
            this.textBoxConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxConsulta.Location = new System.Drawing.Point(483, 74);
            this.textBoxConsulta.MaxLength = 10;
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(199, 23);
            this.textBoxConsulta.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(281, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Número de Factura";
            // 
            // lTitulo
            // 
            this.lTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(322, 19);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(492, 31);
            this.lTitulo.TabIndex = 6;
            this.lTitulo.Text = "MODIFICACIÓN DE VENTA";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(721, 64);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 33);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.validarNombre2);
            this.groupBox2.Controls.Add(this.validarApellido);
            this.groupBox2.Controls.Add(this.validarNombre);
            this.groupBox2.Controls.Add(this.validarCedula);
            this.groupBox2.Controls.Add(this.textBoxCedula);
            this.groupBox2.Controls.Add(this.labelCedula);
            this.groupBox2.Controls.Add(this.labelApellido2);
            this.groupBox2.Controls.Add(this.textBoxNombre2);
            this.groupBox2.Controls.Add(this.labelNombre2);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 151);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos principales";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Location = new System.Drawing.Point(636, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 39);
            this.panel3.TabIndex = 70;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(332, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 33);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(9, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 33);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(172, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 67;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Antigua y Barbuda ",
            "Argentina ",
            "Bahamas ",
            "Barbados ",
            "Belice ",
            "Bolivia",
            "Brasil",
            "Canadá ",
            "Chile ",
            "Colombia ",
            "Costa Rica ",
            "Cuba ",
            "Dominica",
            "Ecuador ",
            "El Salvador ",
            "Estados Unidos ",
            "Granada ",
            "Guatemala ",
            "Guyana ",
            "Haití ",
            "Honduras ",
            "Jamaica",
            "México ",
            "Nicaragua ",
            "Panamá ",
            "Paraguay",
            "Perú ",
            "República Dominicana ",
            "San Cristóbal y Nieves ",
            "San Vicente y las Granadinas ",
            "Surinam ",
            "Trinidad y Tobago ",
            "Uruguay ",
            "Venezuela "});
            this.comboBox2.Location = new System.Drawing.Point(411, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 26);
            this.comboBox2.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Antigua y Barbuda ",
            "Argentina ",
            "Bahamas ",
            "Barbados ",
            "Belice ",
            "Bolivia",
            "Brasil",
            "Canadá ",
            "Chile ",
            "Colombia ",
            "Costa Rica ",
            "Cuba ",
            "Dominica",
            "Ecuador ",
            "El Salvador ",
            "Estados Unidos ",
            "Granada ",
            "Guatemala ",
            "Guyana ",
            "Haití ",
            "Honduras ",
            "Jamaica",
            "México ",
            "Nicaragua ",
            "Panamá ",
            "Paraguay",
            "Perú ",
            "República Dominicana ",
            "San Cristóbal y Nieves ",
            "San Vicente y las Granadinas ",
            "Surinam ",
            "Trinidad y Tobago ",
            "Uruguay ",
            "Venezuela "});
            this.comboBox1.Location = new System.Drawing.Point(411, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 26);
            this.comboBox1.TabIndex = 53;
            // 
            // validarNombre2
            // 
            this.validarNombre2.AutoSize = true;
            this.validarNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre2.ForeColor = System.Drawing.Color.Red;
            this.validarNombre2.Location = new System.Drawing.Point(716, 79);
            this.validarNombre2.Name = "validarNombre2";
            this.validarNombre2.Size = new System.Drawing.Size(0, 17);
            this.validarNombre2.TabIndex = 52;
            // 
            // validarApellido
            // 
            this.validarApellido.AutoSize = true;
            this.validarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarApellido.ForeColor = System.Drawing.Color.Red;
            this.validarApellido.Location = new System.Drawing.Point(716, 108);
            this.validarApellido.Name = "validarApellido";
            this.validarApellido.Size = new System.Drawing.Size(0, 17);
            this.validarApellido.TabIndex = 51;
            // 
            // validarNombre
            // 
            this.validarNombre.AutoSize = true;
            this.validarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre.ForeColor = System.Drawing.Color.Red;
            this.validarNombre.Location = new System.Drawing.Point(716, 52);
            this.validarNombre.Name = "validarNombre";
            this.validarNombre.Size = new System.Drawing.Size(0, 17);
            this.validarNombre.TabIndex = 50;
            // 
            // validarCedula
            // 
            this.validarCedula.AutoSize = true;
            this.validarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarCedula.ForeColor = System.Drawing.Color.Red;
            this.validarCedula.Location = new System.Drawing.Point(716, 26);
            this.validarCedula.Name = "validarCedula";
            this.validarCedula.Size = new System.Drawing.Size(0, 17);
            this.validarCedula.TabIndex = 49;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCedula.AutoCompleteCustomSource.AddRange(new string[] {
            "1718029042"});
            this.textBoxCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCedula.Location = new System.Drawing.Point(411, 20);
            this.textBoxCedula.MaxLength = 10;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(199, 23);
            this.textBoxCedula.TabIndex = 43;
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelCedula.Location = new System.Drawing.Point(219, 20);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(181, 25);
            this.labelCedula.TabIndex = 48;
            this.labelCedula.Text = "Cédula Vendedor";
            // 
            // labelApellido2
            // 
            this.labelApellido2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido2.Location = new System.Drawing.Point(252, 104);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(148, 25);
            this.labelApellido2.TabIndex = 47;
            this.labelApellido2.Text = "Tipo de Venta";
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre2.Location = new System.Drawing.Point(411, 76);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombre2.TabIndex = 44;
            // 
            // labelNombre2
            // 
            this.labelNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(193, 76);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(207, 25);
            this.labelNombre2.TabIndex = 46;
            this.labelNombre2.Text = "Cédula/RUC Cliente";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(318, 49);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 45;
            this.labelNombre.Text = "Nombre";
            // 
            // ModificacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificacionVenta";
            this.Text = "ConsultarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label validarConsulta;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label validarNombre2;
        private System.Windows.Forms.Label validarApellido;
        private System.Windows.Forms.Label validarNombre;
        private System.Windows.Forms.Label validarCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelNombre;
    }
}