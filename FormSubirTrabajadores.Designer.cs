namespace ProyectoRolesConCrystal
{
    partial class FormSubirTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubirTrabajadores));
            this.dgvConsultaTabla = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkDiscapacidad = new System.Windows.Forms.CheckBox();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.chkPasaporte = new System.Windows.Forms.CheckBox();
            this.txtPorcentajeD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDiscapacidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtConvencional = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbUnionH = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            this.dgvConsultaTabla.AllowUserToAddRows = false;
            this.dgvConsultaTabla.AllowUserToDeleteRows = false;
            this.dgvConsultaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTabla.Location = new System.Drawing.Point(1260, 13);
            this.dgvConsultaTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaTabla.Name = "dgvConsultaTabla";
            this.dgvConsultaTabla.ReadOnly = true;
            this.dgvConsultaTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaTabla.Size = new System.Drawing.Size(560, 470);
            this.dgvConsultaTabla.TabIndex = 0;
            this.dgvConsultaTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaTabla_CellContentClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(213, 71);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.MaxLength = 20;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(417, 24);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(855, 802);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(417, 24);
            this.txtCargo.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(732, 858);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(171, 24);
            this.txtSueldo.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(213, 294);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(417, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(796, 557);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(160, 25);
            this.cmbLocalidad.TabIndex = 7;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(1094, 557);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(160, 25);
            this.cmbDepartamento.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::ProyectoRolesConCrystal.Properties.Resources.limpio;
            this.btnLimpiar.Location = new System.Drawing.Point(484, 3);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(43, 43);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkDiscapacidad
            // 
            this.chkDiscapacidad.AutoSize = true;
            this.chkDiscapacidad.Location = new System.Drawing.Point(213, 135);
            this.chkDiscapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiscapacidad.Name = "chkDiscapacidad";
            this.chkDiscapacidad.Size = new System.Drawing.Size(296, 21);
            this.chkDiscapacidad.TabIndex = 14;
            this.chkDiscapacidad.Text = "¿El colaborador poseé alguna discapacidad?";
            this.chkDiscapacidad.UseVisualStyleBackColor = true;
            this.chkDiscapacidad.CheckedChanged += new System.EventHandler(this.chkDiscapacidad_CheckedChanged);
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaI.Location = new System.Drawing.Point(839, 641);
            this.dtpFechaI.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(117, 24);
            this.dtpFechaI.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos y nombres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 805);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cargo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 861);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sueldo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo Primario:";
            // 
            // btnAgg
            // 
            this.btnAgg.FlatAppearance.BorderSize = 0;
            this.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgg.Image = global::ProyectoRolesConCrystal.Properties.Resources.agregar_usuario__1_;
            this.btnAgg.Location = new System.Drawing.Point(297, 3);
            this.btnAgg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(43, 43);
            this.btnAgg.TabIndex = 13;
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnEli
            // 
            this.btnEli.FlatAppearance.BorderSize = 0;
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEli.Image = global::ProyectoRolesConCrystal.Properties.Resources.quitar_usuario;
            this.btnEli.Location = new System.Drawing.Point(424, 3);
            this.btnEli.Margin = new System.Windows.Forms.Padding(4);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(43, 43);
            this.btnEli.TabIndex = 11;
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnMod
            // 
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Image = global::ProyectoRolesConCrystal.Properties.Resources.boton_editar;
            this.btnMod.Location = new System.Drawing.Point(361, 3);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(43, 43);
            this.btnMod.TabIndex = 10;
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Localidad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(979, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Departamento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha de Ingreso :";
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(1104, 743);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 25;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(1185, 743);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(75, 23);
            this.btnReactivar.TabIndex = 26;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(1185, 714);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 27;
            this.btnInforme.Text = "button1";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // chkPasaporte
            // 
            this.chkPasaporte.AutoSize = true;
            this.chkPasaporte.Location = new System.Drawing.Point(638, 74);
            this.chkPasaporte.Name = "chkPasaporte";
            this.chkPasaporte.Size = new System.Drawing.Size(101, 21);
            this.chkPasaporte.TabIndex = 28;
            this.chkPasaporte.Text = "¿Pasaporte?";
            this.chkPasaporte.UseVisualStyleBackColor = true;
            // 
            // txtPorcentajeD
            // 
            this.txtPorcentajeD.Enabled = false;
            this.txtPorcentajeD.Location = new System.Drawing.Point(213, 166);
            this.txtPorcentajeD.Name = "txtPorcentajeD";
            this.txtPorcentajeD.Size = new System.Drawing.Size(100, 24);
            this.txtPorcentajeD.TabIndex = 29;
            this.txtPorcentajeD.Leave += new System.EventHandler(this.txtPorcentajeD_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(24, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Porcentaje de discapacidad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(319, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tipo de discapacidad :";
            // 
            // cmbDiscapacidad
            // 
            this.cmbDiscapacidad.Enabled = false;
            this.cmbDiscapacidad.FormattingEnabled = true;
            this.cmbDiscapacidad.Location = new System.Drawing.Point(469, 165);
            this.cmbDiscapacidad.Name = "cmbDiscapacidad";
            this.cmbDiscapacidad.Size = new System.Drawing.Size(161, 25);
            this.cmbDiscapacidad.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(213, 202);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaNacimiento.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(481, 199);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(149, 24);
            this.txtEdad.TabIndex = 36;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(213, 232);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 24);
            this.txtNacionalidad.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(109, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nacionalidad :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Teléfono convencional :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Celular :";
            // 
            // txtConvencional
            // 
            this.txtConvencional.Location = new System.Drawing.Point(213, 262);
            this.txtConvencional.Name = "txtConvencional";
            this.txtConvencional.Size = new System.Drawing.Size(200, 24);
            this.txtConvencional.TabIndex = 41;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(481, 261);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(149, 24);
            this.txtCelular.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "Correo Secundario:";
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Location = new System.Drawing.Point(213, 329);
            this.txtCorreo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(417, 24);
            this.txtCorreo2.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(124, 367);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 17);
            this.label18.TabIndex = 48;
            this.label18.Text = "Estado Civil:";
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(213, 366);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(81, 21);
            this.rdbSoltero.TabIndex = 45;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero/a";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(213, 393);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(83, 21);
            this.rdbCasado.TabIndex = 46;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado/a";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbUnionH
            // 
            this.rdbUnionH.AutoSize = true;
            this.rdbUnionH.Location = new System.Drawing.Point(213, 420);
            this.rdbUnionH.Name = "rdbUnionH";
            this.rdbUnionH.Size = new System.Drawing.Size(127, 21);
            this.rdbUnionH.TabIndex = 47;
            this.rdbUnionH.TabStop = true;
            this.rdbUnionH.Text = "Union de hechos";
            this.rdbUnionH.UseVisualStyleBackColor = true;
            // 
            // FormSubirTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1431, 838);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rdbUnionH);
            this.Controls.Add(this.rdbCasado);
            this.Controls.Add(this.rdbSoltero);
            this.Controls.Add(this.txtCorreo2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtConvencional);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbDiscapacidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPorcentajeD);
            this.Controls.Add(this.chkPasaporte);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaI);
            this.Controls.Add(this.chkDiscapacidad);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dgvConsultaTabla);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubirTrabajadores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha del Trabajador";
            this.Load += new System.EventHandler(this.FormSubirTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaTabla;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.CheckBox chkDiscapacidad;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.CheckBox chkPasaporte;
        private System.Windows.Forms.TextBox txtPorcentajeD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDiscapacidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConvencional;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbUnionH;
    }
}