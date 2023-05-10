namespace ProyectoRolesConCrystal
{
    partial class FormUtilidadesExcel
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
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.cboHojas = new System.Windows.Forms.ComboBox();
            this.btnMostrarHojas = new System.Windows.Forms.Button();
            this.btnSubirNomina = new System.Windows.Forms.Button();
            this.btnSubirTrabajadores = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(518, 45);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArchivo.TabIndex = 0;
            this.btnBuscarArchivo.Text = "button1";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(214, 47);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRutaArchivo.Size = new System.Drawing.Size(271, 20);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // cboHojas
            // 
            this.cboHojas.FormattingEnabled = true;
            this.cboHojas.Location = new System.Drawing.Point(214, 113);
            this.cboHojas.Name = "cboHojas";
            this.cboHojas.Size = new System.Drawing.Size(271, 21);
            this.cboHojas.TabIndex = 2;
            // 
            // btnMostrarHojas
            // 
            this.btnMostrarHojas.Location = new System.Drawing.Point(518, 111);
            this.btnMostrarHojas.Name = "btnMostrarHojas";
            this.btnMostrarHojas.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarHojas.TabIndex = 3;
            this.btnMostrarHojas.Text = "button1";
            this.btnMostrarHojas.UseVisualStyleBackColor = true;
            this.btnMostrarHojas.Click += new System.EventHandler(this.btnMostrarHojas_Click);
            // 
            // btnSubirNomina
            // 
            this.btnSubirNomina.Location = new System.Drawing.Point(29, 415);
            this.btnSubirNomina.Name = "btnSubirNomina";
            this.btnSubirNomina.Size = new System.Drawing.Size(75, 23);
            this.btnSubirNomina.TabIndex = 4;
            this.btnSubirNomina.Text = "button1";
            this.btnSubirNomina.UseVisualStyleBackColor = true;
            // 
            // btnSubirTrabajadores
            // 
            this.btnSubirTrabajadores.Location = new System.Drawing.Point(704, 415);
            this.btnSubirTrabajadores.Name = "btnSubirTrabajadores";
            this.btnSubirTrabajadores.Size = new System.Drawing.Size(75, 23);
            this.btnSubirTrabajadores.TabIndex = 5;
            this.btnSubirTrabajadores.Text = "button2";
            this.btnSubirTrabajadores.UseVisualStyleBackColor = true;
            this.btnSubirTrabajadores.Click += new System.EventHandler(this.btnSubirTrabajadores_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 140);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(784, 269);
            this.dgvDatos.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUtilidadesExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnSubirTrabajadores);
            this.Controls.Add(this.btnSubirNomina);
            this.Controls.Add(this.btnMostrarHojas);
            this.Controls.Add(this.cboHojas);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Name = "FormUtilidadesExcel";
            this.Text = "FormUtilidadesExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.ComboBox cboHojas;
        private System.Windows.Forms.Button btnMostrarHojas;
        private System.Windows.Forms.Button btnSubirNomina;
        private System.Windows.Forms.Button btnSubirTrabajadores;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button button1;
    }
}