namespace ProyectoRolesConCrystal
{
    partial class frmBusquedaN
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
            this.cmbOpcionesB = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOpcionesB
            // 
            this.cmbOpcionesB.FormattingEnabled = true;
            this.cmbOpcionesB.Location = new System.Drawing.Point(12, 12);
            this.cmbOpcionesB.Name = "cmbOpcionesB";
            this.cmbOpcionesB.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcionesB.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 48);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(298, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // dgvResultadoBusqueda
            // 
            this.dgvResultadoBusqueda.AllowUserToAddRows = false;
            this.dgvResultadoBusqueda.AllowUserToDeleteRows = false;
            this.dgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvResultadoBusqueda.Location = new System.Drawing.Point(12, 85);
            this.dgvResultadoBusqueda.Name = "dgvResultadoBusqueda";
            this.dgvResultadoBusqueda.ReadOnly = true;
            this.dgvResultadoBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusqueda.Size = new System.Drawing.Size(510, 209);
            this.dgvResultadoBusqueda.TabIndex = 2;
            this.dgvResultadoBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoBusqueda_CellContentClick);
            // 
            // frmBusquedaN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.dgvResultadoBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmbOpcionesB);
            this.Name = "frmBusquedaN";
            this.Text = "frmBusquedaN";
            this.Load += new System.EventHandler(this.frmBusquedaN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpcionesB;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvResultadoBusqueda;
    }
}