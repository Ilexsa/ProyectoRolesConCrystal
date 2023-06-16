namespace ProyectoRolesConCrystal
{
    partial class frmContratos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContratos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContrato = new System.Windows.Forms.DataGridView();
            this.btnAggContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento contratos";
            // 
            // txtContratos
            // 
            this.txtContratos.Location = new System.Drawing.Point(68, 75);
            this.txtContratos.Name = "txtContratos";
            this.txtContratos.Size = new System.Drawing.Size(287, 20);
            this.txtContratos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrato :";
            // 
            // dgvContrato
            // 
            this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrato.Location = new System.Drawing.Point(12, 101);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.Size = new System.Drawing.Size(424, 275);
            this.dgvContrato.TabIndex = 3;
            // 
            // btnAggContrato
            // 
            this.btnAggContrato.Location = new System.Drawing.Point(361, 72);
            this.btnAggContrato.Name = "btnAggContrato";
            this.btnAggContrato.Size = new System.Drawing.Size(75, 23);
            this.btnAggContrato.TabIndex = 4;
            this.btnAggContrato.Text = "Agg";
            this.btnAggContrato.UseVisualStyleBackColor = true;
            this.btnAggContrato.Click += new System.EventHandler(this.btnAggContrato_Click);
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 388);
            this.Controls.Add(this.btnAggContrato);
            this.Controls.Add(this.dgvContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContratos);
            this.Controls.Add(this.label1);
            this.Name = "frmContratos";
            this.Text = "frmContratos";
            this.Load += new System.EventHandler(this.frmContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContratos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.Button btnAggContrato;
    }
}