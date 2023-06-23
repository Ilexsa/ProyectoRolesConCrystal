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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubirTrabajadores));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.chkDiscapacidad = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEdicion = new System.Windows.Forms.Button();
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPrimerRegistro = new System.Windows.Forms.Button();
            this.btnUltimoRegistro = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtIDSectorial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbUnionH = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoIESS = new System.Windows.Forms.TextBox();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtGmap = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkEnlace = new System.Windows.Forms.CheckBox();
            this.btnBuscarSectorial = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtReferencias = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cachedReporteColaboradores1 = new ProyectoRolesConCrystal.CachedReporteColaboradores();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(268, 20);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.MaxLength = 20;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(417, 24);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(268, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(266, 239);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(417, 24);
            this.txtCorreo.TabIndex = 11;
            // 
            // chkDiscapacidad
            // 
            this.chkDiscapacidad.AutoSize = true;
            this.chkDiscapacidad.Enabled = false;
            this.chkDiscapacidad.Location = new System.Drawing.Point(268, 84);
            this.chkDiscapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiscapacidad.Name = "chkDiscapacidad";
            this.chkDiscapacidad.Size = new System.Drawing.Size(296, 21);
            this.chkDiscapacidad.TabIndex = 3;
            this.chkDiscapacidad.Text = "¿El colaborador poseé alguna discapacidad?";
            this.chkDiscapacidad.UseVisualStyleBackColor = true;
            this.chkDiscapacidad.CheckedChanged += new System.EventHandler(this.chkDiscapacidad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(122, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos y nombres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(148, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo Primario:";
            // 
            // chkPasaporte
            // 
            this.chkPasaporte.AutoSize = true;
            this.chkPasaporte.Enabled = false;
            this.chkPasaporte.Location = new System.Drawing.Point(692, 23);
            this.chkPasaporte.Name = "chkPasaporte";
            this.chkPasaporte.Size = new System.Drawing.Size(101, 21);
            this.chkPasaporte.TabIndex = 28;
            this.chkPasaporte.Text = "¿Pasaporte?";
            this.chkPasaporte.UseVisualStyleBackColor = true;
            // 
            // txtPorcentajeD
            // 
            this.txtPorcentajeD.Enabled = false;
            this.txtPorcentajeD.Location = new System.Drawing.Point(266, 111);
            this.txtPorcentajeD.Name = "txtPorcentajeD";
            this.txtPorcentajeD.Size = new System.Drawing.Size(100, 24);
            this.txtPorcentajeD.TabIndex = 4;
            this.txtPorcentajeD.Leave += new System.EventHandler(this.txtPorcentajeD_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(77, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Porcentaje de discapacidad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(389, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tipo de discapacidad :";
            // 
            // cmbDiscapacidad
            // 
            this.cmbDiscapacidad.Enabled = false;
            this.cmbDiscapacidad.FormattingEnabled = true;
            this.cmbDiscapacidad.Location = new System.Drawing.Point(534, 110);
            this.cmbDiscapacidad.Name = "cmbDiscapacidad";
            this.cmbDiscapacidad.Size = new System.Drawing.Size(149, 25);
            this.cmbDiscapacidad.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(121, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 33;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(266, 147);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaNacimiento.TabIndex = 6;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(486, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(534, 147);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(149, 24);
            this.txtEdad.TabIndex = 7;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Enabled = false;
            this.txtNacionalidad.Location = new System.Drawing.Point(266, 177);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 24);
            this.txtNacionalidad.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(162, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nacionalidad :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(108, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Teléfono convencional :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(475, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Celular :";
            // 
            // txtConvencional
            // 
            this.txtConvencional.Enabled = false;
            this.txtConvencional.Location = new System.Drawing.Point(266, 207);
            this.txtConvencional.Name = "txtConvencional";
            this.txtConvencional.Size = new System.Drawing.Size(200, 24);
            this.txtConvencional.TabIndex = 10;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(535, 177);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(149, 24);
            this.txtCelular.TabIndex = 9;
            // 
            // txtLng
            // 
            this.txtLng.Enabled = false;
            this.txtLng.Location = new System.Drawing.Point(692, 460);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(277, 24);
            this.txtLng.TabIndex = 55;
            this.txtLng.Visible = false;
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(692, 423);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(277, 24);
            this.txtLat.TabIndex = 56;
            this.txtLat.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(13, 311);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 39);
            this.btnBuscar.TabIndex = 105;
            this.btnBuscar.Text = "🔎";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Trabajador");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdicion
            // 
            this.btnEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdicion.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdicion.Location = new System.Drawing.Point(13, 353);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Size = new System.Drawing.Size(43, 39);
            this.btnEdicion.TabIndex = 106;
            this.btnEdicion.Text = "✍️";
            this.toolTip1.SetToolTip(this.btnEdicion, "Habilitar Edicion/Deshabilitar");
            this.btnEdicion.UseVisualStyleBackColor = true;
            this.btnEdicion.Click += new System.EventHandler(this.btnEdicion_Click);
            // 
            // btnAgg
            // 
            this.btnAgg.FlatAppearance.BorderSize = 0;
            this.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgg.Image = global::ProyectoRolesConCrystal.Properties.Resources.agregar_usuario__1_;
            this.btnAgg.Location = new System.Drawing.Point(12, 129);
            this.btnAgg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(43, 43);
            this.btnAgg.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnAgg, "Agregar Trabajador");
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::ProyectoRolesConCrystal.Properties.Resources.limpio;
            this.btnLimpiar.Location = new System.Drawing.Point(13, 268);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(43, 43);
            this.btnLimpiar.TabIndex = 104;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar Campos");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEli
            // 
            this.btnEli.FlatAppearance.BorderSize = 0;
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEli.Image = global::ProyectoRolesConCrystal.Properties.Resources.quitar_usuario;
            this.btnEli.Location = new System.Drawing.Point(12, 225);
            this.btnEli.Margin = new System.Windows.Forms.Padding(4);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(43, 43);
            this.btnEli.TabIndex = 103;
            this.toolTip1.SetToolTip(this.btnEli, "Eliminar Trabajador");
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnMod
            // 
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Image = global::ProyectoRolesConCrystal.Properties.Resources.boton_editar;
            this.btnMod.Location = new System.Drawing.Point(12, 177);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(43, 43);
            this.btnMod.TabIndex = 102;
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnMod, "Modificar Trabajador");
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPrimerRegistro
            // 
            this.btnPrimerRegistro.Location = new System.Drawing.Point(14, 438);
            this.btnPrimerRegistro.Name = "btnPrimerRegistro";
            this.btnPrimerRegistro.Size = new System.Drawing.Size(42, 39);
            this.btnPrimerRegistro.TabIndex = 108;
            this.btnPrimerRegistro.Text = "<<";
            this.toolTip1.SetToolTip(this.btnPrimerRegistro, "Primer Registro");
            this.btnPrimerRegistro.UseVisualStyleBackColor = true;
            this.btnPrimerRegistro.Click += new System.EventHandler(this.btnPrimerRegistro_Click);
            // 
            // btnUltimoRegistro
            // 
            this.btnUltimoRegistro.Location = new System.Drawing.Point(13, 483);
            this.btnUltimoRegistro.Name = "btnUltimoRegistro";
            this.btnUltimoRegistro.Size = new System.Drawing.Size(42, 39);
            this.btnUltimoRegistro.TabIndex = 109;
            this.btnUltimoRegistro.Text = ">>";
            this.toolTip1.SetToolTip(this.btnUltimoRegistro, "Ultimo Registro");
            this.btnUltimoRegistro.UseVisualStyleBackColor = true;
            this.btnUltimoRegistro.Click += new System.EventHandler(this.btnUltimoRegistro_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(13, 528);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 39);
            this.btnNext.TabIndex = 110;
            this.btnNext.Text = ">";
            this.toolTip1.SetToolTip(this.btnNext, "Siguiente Registro");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 393);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(42, 39);
            this.btnPrevious.TabIndex = 107;
            this.btnPrevious.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevious, "Anterior Registro");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtIDSectorial
            // 
            this.txtIDSectorial.Enabled = false;
            this.txtIDSectorial.Location = new System.Drawing.Point(1426, 357);
            this.txtIDSectorial.Name = "txtIDSectorial";
            this.txtIDSectorial.Size = new System.Drawing.Size(100, 24);
            this.txtIDSectorial.TabIndex = 63;
            this.txtIDSectorial.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(117, 150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 17);
            this.label23.TabIndex = 70;
            this.label23.Text = "Fcha de Nacimiento :";
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(268, 760);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(417, 24);
            this.txtCargo.TabIndex = 23;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Location = new System.Drawing.Point(268, 860);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(171, 24);
            this.txtSueldo.TabIndex = 27;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Enabled = false;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.ItemHeight = 17;
            this.cmbLocalidad.Location = new System.Drawing.Point(268, 792);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(149, 25);
            this.cmbLocalidad.TabIndex = 24;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.ItemHeight = 17;
            this.cmbDepartamento.Location = new System.Drawing.Point(536, 793);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(149, 25);
            this.cmbDepartamento.TabIndex = 25;
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Enabled = false;
            this.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaI.Location = new System.Drawing.Point(268, 828);
            this.dtpFechaI.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(117, 24);
            this.dtpFechaI.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(206, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cargo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(203, 863);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sueldo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(184, 796);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Localidad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(427, 796);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Departamento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(141, 828);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha de Ingreso :";
            // 
            // btnInactivar
            // 
            this.btnInactivar.Enabled = false;
            this.btnInactivar.Location = new System.Drawing.Point(820, 861);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 120;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.Enabled = false;
            this.btnReactivar.Location = new System.Drawing.Point(901, 861);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(75, 23);
            this.btnReactivar.TabIndex = 130;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(132, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "Correo Secundario:";
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Enabled = false;
            this.txtCorreo2.Location = new System.Drawing.Point(266, 274);
            this.txtCorreo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(417, 24);
            this.txtCorreo2.TabIndex = 12;
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Enabled = false;
            this.rdbSoltero.Location = new System.Drawing.Point(268, 682);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(81, 21);
            this.rdbSoltero.TabIndex = 17;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero/a";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Enabled = false;
            this.rdbCasado.Location = new System.Drawing.Point(268, 709);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(83, 21);
            this.rdbCasado.TabIndex = 18;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado/a";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbUnionH
            // 
            this.rdbUnionH.AutoSize = true;
            this.rdbUnionH.Enabled = false;
            this.rdbUnionH.Location = new System.Drawing.Point(268, 736);
            this.rdbUnionH.Name = "rdbUnionH";
            this.rdbUnionH.Size = new System.Drawing.Size(127, 21);
            this.rdbUnionH.TabIndex = 19;
            this.rdbUnionH.TabStop = true;
            this.rdbUnionH.Text = "Union de hechos";
            this.rdbUnionH.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(179, 683);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 17);
            this.label18.TabIndex = 48;
            this.label18.Text = "Estado Civil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(420, 709);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Código Sectorial :";
            // 
            // txtCodigoIESS
            // 
            this.txtCodigoIESS.Enabled = false;
            this.txtCodigoIESS.Location = new System.Drawing.Point(537, 706);
            this.txtCodigoIESS.Name = "txtCodigoIESS";
            this.txtCodigoIESS.Size = new System.Drawing.Size(149, 24);
            this.txtCodigoIESS.TabIndex = 21;
            // 
            // cmbContrato
            // 
            this.cmbContrato.Enabled = false;
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(537, 675);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(149, 25);
            this.cmbContrato.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(417, 678);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 17);
            this.label19.TabIndex = 52;
            this.label19.Text = "Tipo de contrato :";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.Enabled = false;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(266, 438);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(416, 231);
            this.gMapControl1.TabIndex = 54;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // txtGmap
            // 
            this.txtGmap.Enabled = false;
            this.txtGmap.Location = new System.Drawing.Point(268, 408);
            this.txtGmap.Name = "txtGmap";
            this.txtGmap.Size = new System.Drawing.Size(243, 24);
            this.txtGmap.TabIndex = 16;
            this.txtGmap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGmap_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(79, 408);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 17);
            this.label20.TabIndex = 58;
            this.label20.Text = "Coordenadas Google Maps :";
            // 
            // chkEnlace
            // 
            this.chkEnlace.AutoSize = true;
            this.chkEnlace.Enabled = false;
            this.chkEnlace.Location = new System.Drawing.Point(520, 411);
            this.chkEnlace.Name = "chkEnlace";
            this.chkEnlace.Size = new System.Drawing.Size(114, 21);
            this.chkEnlace.TabIndex = 17;
            this.chkEnlace.Text = "¿Es un enlace?";
            this.chkEnlace.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSectorial
            // 
            this.btnBuscarSectorial.Enabled = false;
            this.btnBuscarSectorial.Location = new System.Drawing.Point(538, 734);
            this.btnBuscarSectorial.Name = "btnBuscarSectorial";
            this.btnBuscarSectorial.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarSectorial.TabIndex = 22;
            this.btnBuscarSectorial.Text = "Buscar Sectorial";
            this.btnBuscarSectorial.UseVisualStyleBackColor = true;
            this.btnBuscarSectorial.Click += new System.EventHandler(this.btnBuscarSectorial_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(266, 308);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(417, 24);
            this.txtDireccion.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Location = new System.Drawing.Point(186, 311);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 17);
            this.label21.TabIndex = 66;
            this.label21.Text = "Dirección :";
            // 
            // txtReferencias
            // 
            this.txtReferencias.Enabled = false;
            this.txtReferencias.Location = new System.Drawing.Point(266, 338);
            this.txtReferencias.Multiline = true;
            this.txtReferencias.Name = "txtReferencias";
            this.txtReferencias.Size = new System.Drawing.Size(417, 60);
            this.txtReferencias.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Location = new System.Drawing.Point(174, 341);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 17);
            this.label22.TabIndex = 68;
            this.label22.Text = "Referencias :";
            // 
            // btnPDF
            // 
            this.btnPDF.Enabled = false;
            this.btnPDF.Location = new System.Drawing.Point(532, 860);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(154, 23);
            this.btnPDF.TabIndex = 28;
            this.btnPDF.Text = "Subir PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(162, 180);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 17);
            this.label24.TabIndex = 71;
            this.label24.Text = "Nacionalidad :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.Location = new System.Drawing.Point(475, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 72;
            this.label25.Text = "Celular :";
            // 
            // ptbFoto
            // 
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFoto.Enabled = false;
            this.ptbFoto.Location = new System.Drawing.Point(691, 51);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(185, 212);
            this.ptbFoto.TabIndex = 64;
            this.ptbFoto.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(221, 100);
            this.tabControl1.TabIndex = 131;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 70);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 70);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(213, 70);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormSubirTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(995, 952);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUltimoRegistro);
            this.Controls.Add(this.btnPrimerRegistro);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtReferencias);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.txtIDSectorial);
            this.Controls.Add(this.btnBuscarSectorial);
            this.Controls.Add(this.btnEdicion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkEnlace);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtGmap);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbContrato);
            this.Controls.Add(this.txtCodigoIESS);
            this.Controls.Add(this.label8);
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
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubirTrabajadores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Trabajador";
            this.Load += new System.EventHandler(this.FormSubirTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.CheckBox chkDiscapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtIDSectorial;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbUnionH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoIESS;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.Label label19;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtGmap;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkEnlace;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEdicion;
        private System.Windows.Forms.Button btnBuscarSectorial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtReferencias;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnPrimerRegistro;
        private CachedReporteColaboradores cachedReporteColaboradores1;
        private System.Windows.Forms.Button btnUltimoRegistro;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}