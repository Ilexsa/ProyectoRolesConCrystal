namespace ProyectoRolesConCrystal
{
    partial class frmSectoriales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoIESS = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstructuraOcupacional = new System.Windows.Forms.TextBox();
            this.btnPreviousSectorial = new System.Windows.Forms.Button();
            this.btnNextSectorial = new System.Windows.Forms.Button();
            this.btnFirstSectorial = new System.Windows.Forms.Button();
            this.btnLastSectorial = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnHabilitarEdicion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de sectoriales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo IESS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo/Actividad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario minimo sectorial :";
            // 
            // txtCodigoIESS
            // 
            this.txtCodigoIESS.Enabled = false;
            this.txtCodigoIESS.Location = new System.Drawing.Point(165, 93);
            this.txtCodigoIESS.Name = "txtCodigoIESS";
            this.txtCodigoIESS.Size = new System.Drawing.Size(175, 20);
            this.txtCodigoIESS.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(165, 171);
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(175, 61);
            this.txtCargo.TabIndex = 5;
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Enabled = false;
            this.txtSalarioMin.Location = new System.Drawing.Point(165, 119);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(175, 20);
            this.txtSalarioMin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estructura ocupacional :";
            // 
            // txtEstructuraOcupacional
            // 
            this.txtEstructuraOcupacional.Enabled = false;
            this.txtEstructuraOcupacional.Location = new System.Drawing.Point(165, 145);
            this.txtEstructuraOcupacional.Name = "txtEstructuraOcupacional";
            this.txtEstructuraOcupacional.Size = new System.Drawing.Size(54, 20);
            this.txtEstructuraOcupacional.TabIndex = 8;
            // 
            // btnPreviousSectorial
            // 
            this.btnPreviousSectorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSectorial.Location = new System.Drawing.Point(140, 45);
            this.btnPreviousSectorial.Name = "btnPreviousSectorial";
            this.btnPreviousSectorial.Size = new System.Drawing.Size(46, 42);
            this.btnPreviousSectorial.TabIndex = 9;
            this.btnPreviousSectorial.Text = "<";
            this.toolTip1.SetToolTip(this.btnPreviousSectorial, "Anterior");
            this.btnPreviousSectorial.UseVisualStyleBackColor = true;
            this.btnPreviousSectorial.Click += new System.EventHandler(this.btnPreviousSectorial_Click);
            // 
            // btnNextSectorial
            // 
            this.btnNextSectorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSectorial.Location = new System.Drawing.Point(192, 45);
            this.btnNextSectorial.Name = "btnNextSectorial";
            this.btnNextSectorial.Size = new System.Drawing.Size(46, 42);
            this.btnNextSectorial.TabIndex = 10;
            this.btnNextSectorial.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextSectorial, "Siguiente ");
            this.btnNextSectorial.UseVisualStyleBackColor = true;
            this.btnNextSectorial.Click += new System.EventHandler(this.btnNextSectorial_Click);
            // 
            // btnFirstSectorial
            // 
            this.btnFirstSectorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstSectorial.Location = new System.Drawing.Point(91, 45);
            this.btnFirstSectorial.Name = "btnFirstSectorial";
            this.btnFirstSectorial.Size = new System.Drawing.Size(43, 42);
            this.btnFirstSectorial.TabIndex = 11;
            this.btnFirstSectorial.Text = "<<";
            this.toolTip1.SetToolTip(this.btnFirstSectorial, "Primer Registro");
            this.btnFirstSectorial.UseVisualStyleBackColor = true;
            this.btnFirstSectorial.Click += new System.EventHandler(this.btnFirstSectorial_Click);
            // 
            // btnLastSectorial
            // 
            this.btnLastSectorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastSectorial.Location = new System.Drawing.Point(244, 45);
            this.btnLastSectorial.Name = "btnLastSectorial";
            this.btnLastSectorial.Size = new System.Drawing.Size(46, 42);
            this.btnLastSectorial.TabIndex = 12;
            this.btnLastSectorial.Text = ">>";
            this.toolTip1.SetToolTip(this.btnLastSectorial, "Ultimo Registro");
            this.btnLastSectorial.UseVisualStyleBackColor = true;
            this.btnLastSectorial.Click += new System.EventHandler(this.btnLastSectorial_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(402, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 20);
            this.txtID.TabIndex = 13;
            this.txtID.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(294, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 42);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "🔎";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Sectorial");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(430, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(42, 41);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "💾";
            this.toolTip1.SetToolTip(this.btnGuardar, "Grabar/Editar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnHabilitarEdicion
            // 
            this.btnHabilitarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarEdicion.Location = new System.Drawing.Point(349, 45);
            this.btnHabilitarEdicion.Name = "btnHabilitarEdicion";
            this.btnHabilitarEdicion.Size = new System.Drawing.Size(46, 42);
            this.btnHabilitarEdicion.TabIndex = 17;
            this.btnHabilitarEdicion.Text = "✍️";
            this.toolTip1.SetToolTip(this.btnHabilitarEdicion, "Habilitar Edicion");
            this.btnHabilitarEdicion.UseVisualStyleBackColor = true;
            this.btnHabilitarEdicion.Click += new System.EventHandler(this.btnHabilitarEdicion_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::ProyectoRolesConCrystal.Properties.Resources.limpio;
            this.btnLimpiar.Location = new System.Drawing.Point(33, 45);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 42);
            this.btnLimpiar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar Campos");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmSectoriales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnHabilitarEdicion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLastSectorial);
            this.Controls.Add(this.btnFirstSectorial);
            this.Controls.Add(this.btnNextSectorial);
            this.Controls.Add(this.btnPreviousSectorial);
            this.Controls.Add(this.txtEstructuraOcupacional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalarioMin);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCodigoIESS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSectoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sectoriales IESS";
            this.Load += new System.EventHandler(this.frmSectoriales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoIESS;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstructuraOcupacional;
        private System.Windows.Forms.Button btnPreviousSectorial;
        private System.Windows.Forms.Button btnNextSectorial;
        private System.Windows.Forms.Button btnFirstSectorial;
        private System.Windows.Forms.Button btnLastSectorial;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnHabilitarEdicion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}