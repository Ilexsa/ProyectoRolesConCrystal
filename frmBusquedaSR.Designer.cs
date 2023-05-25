namespace ProyectoRolesConCrystal
{
    partial class frmBusquedaSR
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
            this.cmbOpcionesBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOpcionesBusqueda
            // 
            this.cmbOpcionesBusqueda.FormattingEnabled = true;
            this.cmbOpcionesBusqueda.Location = new System.Drawing.Point(22, 23);
            this.cmbOpcionesBusqueda.Name = "cmbOpcionesBusqueda";
            this.cmbOpcionesBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcionesBusqueda.TabIndex = 0;
            // 
            // dgvResultadoBusqueda
            // 
            this.dgvResultadoBusqueda.AllowUserToAddRows = false;
            this.dgvResultadoBusqueda.AllowUserToDeleteRows = false;
            this.dgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusqueda.Location = new System.Drawing.Point(12, 112);
            this.dgvResultadoBusqueda.Name = "dgvResultadoBusqueda";
            this.dgvResultadoBusqueda.ReadOnly = true;
            this.dgvResultadoBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusqueda.Size = new System.Drawing.Size(631, 150);
            this.dgvResultadoBusqueda.TabIndex = 1;
            this.dgvResultadoBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoBusqueda_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(22, 73);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(407, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(454, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBusquedaSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 274);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvResultadoBusqueda);
            this.Controls.Add(this.cmbOpcionesBusqueda);
            this.Name = "frmBusquedaSR";
            this.Text = "frmBusquedaSR";
            this.Load += new System.EventHandler(this.frmBusquedaSR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpcionesBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultadoBusqueda;
    }
}