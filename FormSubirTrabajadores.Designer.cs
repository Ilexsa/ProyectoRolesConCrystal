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
            this.txtDiscapacidad = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkDiscapacidad = new System.Windows.Forms.CheckBox();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            this.dgvConsultaTabla.AllowUserToAddRows = false;
            this.dgvConsultaTabla.AllowUserToDeleteRows = false;
            this.dgvConsultaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTabla.Location = new System.Drawing.Point(561, 13);
            this.dgvConsultaTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaTabla.Name = "dgvConsultaTabla";
            this.dgvConsultaTabla.ReadOnly = true;
            this.dgvConsultaTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaTabla.Size = new System.Drawing.Size(964, 452);
            this.dgvConsultaTabla.TabIndex = 0;
            this.dgvConsultaTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaTabla_CellContentClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(95, 77);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(417, 24);
            this.txtCedula.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(95, 145);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(417, 24);
            this.txtCargo.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(95, 179);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(171, 24);
            this.txtSueldo.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(95, 213);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(417, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtDiscapacidad
            // 
            this.txtDiscapacidad.Enabled = false;
            this.txtDiscapacidad.Location = new System.Drawing.Point(123, 441);
            this.txtDiscapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscapacidad.Name = "txtDiscapacidad";
            this.txtDiscapacidad.Size = new System.Drawing.Size(257, 24);
            this.txtDiscapacidad.TabIndex = 6;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(95, 256);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(160, 25);
            this.cmbLocalidad.TabIndex = 7;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(393, 256);
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
            this.btnLimpiar.Location = new System.Drawing.Point(343, 13);
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
            this.chkDiscapacidad.Location = new System.Drawing.Point(22, 398);
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
            this.dtpFechaI.Location = new System.Drawing.Point(138, 340);
            this.dtpFechaI.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(242, 24);
            this.dtpFechaI.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(19, 444);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Discapacidad :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cargo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sueldo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo :";
            // 
            // btnAgg
            // 
            this.btnAgg.FlatAppearance.BorderSize = 0;
            this.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgg.Image = global::ProyectoRolesConCrystal.Properties.Resources.agregar_usuario__1_;
            this.btnAgg.Location = new System.Drawing.Point(156, 13);
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
            this.btnEli.Location = new System.Drawing.Point(283, 13);
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
            this.btnMod.Location = new System.Drawing.Point(220, 13);
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
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Localidad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Departamento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha de Ingreso :";
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(403, 442);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 25;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(484, 442);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(75, 23);
            this.btnReactivar.TabIndex = 26;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(484, 413);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 27;
            this.btnInforme.Text = "button1";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 487);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1399, 529);
            this.crystalReportViewer1.TabIndex = 28;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormSubirTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1538, 1062);
            this.Controls.Add(this.crystalReportViewer1);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaI);
            this.Controls.Add(this.chkDiscapacidad);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtDiscapacidad);
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
            this.Text = "Registrar Trabajadores";
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
        private System.Windows.Forms.TextBox txtDiscapacidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.CheckBox chkDiscapacidad;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label8;
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}