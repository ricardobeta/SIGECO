namespace SIGECO.Vistas
{
    partial class ModificacionClienteNatural
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxRUC = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.labelRUC = new System.Windows.Forms.Label();
            this.validarRUC = new System.Windows.Forms.Label();
            this.validarCorreo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.labelNombre2Op = new System.Windows.Forms.Label();
            this.labelApellido2Op = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.validarCedula = new System.Windows.Forms.Label();
            this.validarNombre = new System.Windows.Forms.Label();
            this.validarApellido2 = new System.Windows.Forms.Label();
            this.validarApellido = new System.Windows.Forms.Label();
            this.validarNombre2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Controls.Add(this.groupBox1);
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
            this.textBoxConsulta.TextChanged += new System.EventHandler(this.textBoxConsulta_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(260, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Consultar por Cédula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.lTitulo.Text = "MODIFICACIÓN DE CLIENTE NATURAL";
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
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Location = new System.Drawing.Point(696, 429);
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
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.pCerrar_Click);
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
            // textBoxRUC
            // 
            this.textBoxRUC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRUC.Location = new System.Drawing.Point(406, 16);
            this.textBoxRUC.MaxLength = 13;
            this.textBoxRUC.Name = "textBoxRUC";
            this.textBoxRUC.Size = new System.Drawing.Size(199, 20);
            this.textBoxRUC.TabIndex = 40;
            this.textBoxRUC.TabStop = false;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(406, 44);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(199, 20);
            this.textBoxCorreo.TabIndex = 8;
            // 
            // labelCorreo
            // 
            this.labelCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(322, 43);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(78, 25);
            this.labelCorreo.TabIndex = 14;
            this.labelCorreo.Text = "Correo";
            // 
            // labelPais
            // 
            this.labelPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPais.Location = new System.Drawing.Point(346, 70);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(54, 25);
            this.labelPais.TabIndex = 15;
            this.labelPais.Text = "País";
            // 
            // cbPais
            // 
            this.cbPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
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
            this.cbPais.Location = new System.Drawing.Point(406, 70);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(199, 26);
            this.cbPais.TabIndex = 9;
            this.cbPais.ValueMember = "Nombre";
            // 
            // labelRUC
            // 
            this.labelRUC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRUC.AutoSize = true;
            this.labelRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUC.Location = new System.Drawing.Point(343, 16);
            this.labelRUC.Name = "labelRUC";
            this.labelRUC.Size = new System.Drawing.Size(57, 25);
            this.labelRUC.TabIndex = 21;
            this.labelRUC.Text = "RUC";
            // 
            // validarRUC
            // 
            this.validarRUC.AutoSize = true;
            this.validarRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarRUC.ForeColor = System.Drawing.Color.Red;
            this.validarRUC.Location = new System.Drawing.Point(711, 19);
            this.validarRUC.Name = "validarRUC";
            this.validarRUC.Size = new System.Drawing.Size(0, 17);
            this.validarRUC.TabIndex = 28;
            // 
            // validarCorreo
            // 
            this.validarCorreo.AutoSize = true;
            this.validarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarCorreo.ForeColor = System.Drawing.Color.Red;
            this.validarCorreo.Location = new System.Drawing.Point(711, 47);
            this.validarCorreo.Name = "validarCorreo";
            this.validarCorreo.Size = new System.Drawing.Size(0, 17);
            this.validarCorreo.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.validarCorreo);
            this.groupBox1.Controls.Add(this.validarRUC);
            this.groupBox1.Controls.Add(this.labelRUC);
            this.groupBox1.Controls.Add(this.cbPais);
            this.groupBox1.Controls.Add(this.labelPais);
            this.groupBox1.Controls.Add(this.labelCorreo);
            this.groupBox1.Controls.Add(this.textBoxCorreo);
            this.groupBox1.Controls.Add(this.textBoxRUC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 119);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información adicional";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(313, 49);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNombre2
            // 
            this.labelNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(214, 76);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(186, 25);
            this.labelNombre2.TabIndex = 19;
            this.labelNombre2.Text = " Segundo Nombre";
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre2.Location = new System.Drawing.Point(406, 76);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombre2.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(406, 49);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(310, 105);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(90, 25);
            this.labelApellido.TabIndex = 20;
            this.labelApellido.Text = "Apellido";
            // 
            // labelApellido2
            // 
            this.labelApellido2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido2.Location = new System.Drawing.Point(217, 134);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(183, 25);
            this.labelApellido2.TabIndex = 21;
            this.labelApellido2.Text = "Segundo Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(406, 105);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(199, 20);
            this.textBoxApellido.TabIndex = 4;
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido2.Location = new System.Drawing.Point(406, 134);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(199, 20);
            this.textBoxApellido2.TabIndex = 5;
            // 
            // labelNombre2Op
            // 
            this.labelNombre2Op.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre2Op.AutoSize = true;
            this.labelNombre2Op.Location = new System.Drawing.Point(611, 78);
            this.labelNombre2Op.Name = "labelNombre2Op";
            this.labelNombre2Op.Size = new System.Drawing.Size(87, 18);
            this.labelNombre2Op.TabIndex = 23;
            this.labelNombre2Op.Text = "(Opcional)";
            // 
            // labelApellido2Op
            // 
            this.labelApellido2Op.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido2Op.AutoSize = true;
            this.labelApellido2Op.Location = new System.Drawing.Point(611, 136);
            this.labelApellido2Op.Name = "labelApellido2Op";
            this.labelApellido2Op.Size = new System.Drawing.Size(87, 18);
            this.labelApellido2Op.TabIndex = 24;
            this.labelApellido2Op.Text = "(Opcional)";
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelCedula.Location = new System.Drawing.Point(319, 20);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(81, 25);
            this.labelCedula.TabIndex = 22;
            this.labelCedula.Text = "Cédula";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCedula.AutoCompleteCustomSource.AddRange(new string[] {
            "1718029042"});
            this.textBoxCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCedula.Location = new System.Drawing.Point(406, 20);
            this.textBoxCedula.MaxLength = 10;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(199, 23);
            this.textBoxCedula.TabIndex = 1;
            this.textBoxCedula.Leave += new System.EventHandler(this.textBoxCedula_Leave);
            // 
            // validarCedula
            // 
            this.validarCedula.AutoSize = true;
            this.validarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarCedula.ForeColor = System.Drawing.Color.Red;
            this.validarCedula.Location = new System.Drawing.Point(711, 26);
            this.validarCedula.Name = "validarCedula";
            this.validarCedula.Size = new System.Drawing.Size(0, 17);
            this.validarCedula.TabIndex = 25;
            // 
            // validarNombre
            // 
            this.validarNombre.AutoSize = true;
            this.validarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre.ForeColor = System.Drawing.Color.Red;
            this.validarNombre.Location = new System.Drawing.Point(711, 52);
            this.validarNombre.Name = "validarNombre";
            this.validarNombre.Size = new System.Drawing.Size(0, 17);
            this.validarNombre.TabIndex = 26;
            // 
            // validarApellido2
            // 
            this.validarApellido2.AutoSize = true;
            this.validarApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarApellido2.ForeColor = System.Drawing.Color.Red;
            this.validarApellido2.Location = new System.Drawing.Point(711, 137);
            this.validarApellido2.Name = "validarApellido2";
            this.validarApellido2.Size = new System.Drawing.Size(0, 17);
            this.validarApellido2.TabIndex = 27;
            // 
            // validarApellido
            // 
            this.validarApellido.AutoSize = true;
            this.validarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarApellido.ForeColor = System.Drawing.Color.Red;
            this.validarApellido.Location = new System.Drawing.Point(711, 108);
            this.validarApellido.Name = "validarApellido";
            this.validarApellido.Size = new System.Drawing.Size(0, 17);
            this.validarApellido.TabIndex = 28;
            // 
            // validarNombre2
            // 
            this.validarNombre2.AutoSize = true;
            this.validarNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarNombre2.ForeColor = System.Drawing.Color.Red;
            this.validarNombre2.Location = new System.Drawing.Point(711, 79);
            this.validarNombre2.Name = "validarNombre2";
            this.validarNombre2.Size = new System.Drawing.Size(0, 17);
            this.validarNombre2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(406, 169);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(199, 20);
            this.textBoxTelefono.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxTelefono);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.validarNombre2);
            this.groupBox2.Controls.Add(this.validarApellido);
            this.groupBox2.Controls.Add(this.validarApellido2);
            this.groupBox2.Controls.Add(this.validarNombre);
            this.groupBox2.Controls.Add(this.validarCedula);
            this.groupBox2.Controls.Add(this.textBoxCedula);
            this.groupBox2.Controls.Add(this.labelCedula);
            this.groupBox2.Controls.Add(this.labelApellido2Op);
            this.groupBox2.Controls.Add(this.labelNombre2Op);
            this.groupBox2.Controls.Add(this.textBoxApellido2);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.labelApellido2);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.textBoxNombre2);
            this.groupBox2.Controls.Add(this.labelNombre2);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 197);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos principales";
            // 
            // ModificacionClienteNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificacionClienteNatural";
            this.Text = "ConsultarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label validarConsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label validarNombre2;
        private System.Windows.Forms.Label validarApellido;
        private System.Windows.Forms.Label validarApellido2;
        private System.Windows.Forms.Label validarNombre;
        private System.Windows.Forms.Label validarCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelApellido2Op;
        private System.Windows.Forms.Label labelNombre2Op;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label validarCorreo;
        private System.Windows.Forms.Label validarRUC;
        private System.Windows.Forms.Label labelRUC;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxRUC;
    }
}