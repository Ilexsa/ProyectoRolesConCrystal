namespace ProyectoRolesConCrystal
{
    partial class frmCargas
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
            this.btnSubirCarga = new System.Windows.Forms.Button();
            this.cmbTipoCarga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDiscapacidad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPorcentajeD = new System.Windows.Forms.TextBox();
            this.chkDiscapacidad = new System.Windows.Forms.CheckBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPasaporte = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubirCarga
            // 
            this.btnSubirCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirCarga.Location = new System.Drawing.Point(578, 179);
            this.btnSubirCarga.Name = "btnSubirCarga";
            this.btnSubirCarga.Size = new System.Drawing.Size(43, 37);
            this.btnSubirCarga.TabIndex = 0;
            this.btnSubirCarga.Text = "💾";
            this.btnSubirCarga.UseVisualStyleBackColor = true;
            this.btnSubirCarga.Click += new System.EventHandler(this.btnSubirCarga_Click);
            // 
            // cmbTipoCarga
            // 
            this.cmbTipoCarga.FormattingEnabled = true;
            this.cmbTipoCarga.Location = new System.Drawing.Point(129, 44);
            this.cmbTipoCarga.Name = "cmbTipoCarga";
            this.cmbTipoCarga.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de carga :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos y Nombres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento :";
            // 
            // cmbDiscapacidad
            // 
            this.cmbDiscapacidad.Enabled = false;
            this.cmbDiscapacidad.FormattingEnabled = true;
            this.cmbDiscapacidad.Location = new System.Drawing.Point(394, 185);
            this.cmbDiscapacidad.Name = "cmbDiscapacidad";
            this.cmbDiscapacidad.Size = new System.Drawing.Size(149, 21);
            this.cmbDiscapacidad.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(273, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tipo de discapacidad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(17, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Porcentaje de discapacidad :";
            // 
            // txtPorcentajeD
            // 
            this.txtPorcentajeD.Enabled = false;
            this.txtPorcentajeD.Location = new System.Drawing.Point(168, 186);
            this.txtPorcentajeD.Name = "txtPorcentajeD";
            this.txtPorcentajeD.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeD.TabIndex = 34;
            this.txtPorcentajeD.Leave += new System.EventHandler(this.txtPorcentajeD_Leave);
            // 
            // chkDiscapacidad
            // 
            this.chkDiscapacidad.AutoSize = true;
            this.chkDiscapacidad.Location = new System.Drawing.Point(82, 159);
            this.chkDiscapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiscapacidad.Name = "chkDiscapacidad";
            this.chkDiscapacidad.Size = new System.Drawing.Size(169, 17);
            this.chkDiscapacidad.TabIndex = 33;
            this.chkDiscapacidad.Text = "¿Poseé alguna discapacidad?";
            this.chkDiscapacidad.UseVisualStyleBackColor = true;
            this.chkDiscapacidad.CheckedChanged += new System.EventHandler(this.chkDiscapacidad_CheckedChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(129, 71);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 20);
            this.txtCedula.TabIndex = 38;
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(129, 97);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(302, 20);
            this.txtNombres.TabIndex = 39;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(129, 123);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaNacimiento.TabIndex = 40;
            this.dtpFechaNacimiento.Leave += new System.EventHandler(this.dtpFechaNacimiento_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cargas";
            // 
            // chkPasaporte
            // 
            this.chkPasaporte.AutoSize = true;
            this.chkPasaporte.Location = new System.Drawing.Point(335, 73);
            this.chkPasaporte.Name = "chkPasaporte";
            this.chkPasaporte.Size = new System.Drawing.Size(86, 17);
            this.chkPasaporte.TabIndex = 42;
            this.chkPasaporte.Text = "¿Pasaporte?";
            this.chkPasaporte.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(323, 122);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(42, 20);
            this.txtEdad.TabIndex = 44;
            // 
            // frmCargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 228);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPasaporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cmbDiscapacidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPorcentajeD);
            this.Controls.Add(this.chkDiscapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCarga);
            this.Controls.Add(this.btnSubirCarga);
            this.Name = "frmCargas";
            this.Text = "frmCargas";
            this.Load += new System.EventHandler(this.frmCargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubirCarga;
        private System.Windows.Forms.ComboBox cmbTipoCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDiscapacidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPorcentajeD;
        private System.Windows.Forms.CheckBox chkDiscapacidad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPasaporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdad;
    }
}