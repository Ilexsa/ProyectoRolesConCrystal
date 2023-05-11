namespace ProyectoRolesConCrystal
{
    partial class FormSubirRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubirRoles));
            this.txtNomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAlimentacion = new System.Windows.Forms.TextBox();
            this.txtMovilizacion = new System.Windows.Forms.TextBox();
            this.txtOtrosIngresosNA = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomina
            // 
            this.txtNomina.Location = new System.Drawing.Point(82, 64);
            this.txtNomina.Name = "txtNomina";
            this.txtNomina.Size = new System.Drawing.Size(100, 20);
            this.txtNomina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Nomina :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAlimentacion
            // 
            this.txtAlimentacion.Location = new System.Drawing.Point(290, 170);
            this.txtAlimentacion.Name = "txtAlimentacion";
            this.txtAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentacion.TabIndex = 3;
            // 
            // txtMovilizacion
            // 
            this.txtMovilizacion.Location = new System.Drawing.Point(290, 196);
            this.txtMovilizacion.Name = "txtMovilizacion";
            this.txtMovilizacion.Size = new System.Drawing.Size(100, 20);
            this.txtMovilizacion.TabIndex = 4;
            // 
            // txtOtrosIngresosNA
            // 
            this.txtOtrosIngresosNA.Location = new System.Drawing.Point(290, 222);
            this.txtOtrosIngresosNA.Name = "txtOtrosIngresosNA";
            this.txtOtrosIngresosNA.Size = new System.Drawing.Size(100, 20);
            this.txtOtrosIngresosNA.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(290, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(290, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // FormSubirRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 771);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtOtrosIngresosNA);
            this.Controls.Add(this.txtMovilizacion);
            this.Controls.Add(this.txtAlimentacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSubirRoles";
            this.Text = "Registro de Nomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAlimentacion;
        private System.Windows.Forms.TextBox txtMovilizacion;
        private System.Windows.Forms.TextBox txtOtrosIngresosNA;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}