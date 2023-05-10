namespace ProyectoRolesConCrystal
{
    partial class FormVentanaRol
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correosMasivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.correoIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirTrabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.subirRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.utilidadesExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem,
            this.baseToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correosMasivosToolStripMenuItem,
            this.toolStripSeparator1,
            this.correoIndividualToolStripMenuItem,
            this.toolStripSeparator2});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // correosMasivosToolStripMenuItem
            // 
            this.correosMasivosToolStripMenuItem.Name = "correosMasivosToolStripMenuItem";
            this.correosMasivosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.correosMasivosToolStripMenuItem.Text = "Correos Masivos";
            this.correosMasivosToolStripMenuItem.Click += new System.EventHandler(this.correosMasivosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // correoIndividualToolStripMenuItem
            // 
            this.correoIndividualToolStripMenuItem.Name = "correoIndividualToolStripMenuItem";
            this.correoIndividualToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.correoIndividualToolStripMenuItem.Text = "Correo Individual";
            this.correoIndividualToolStripMenuItem.Click += new System.EventHandler(this.correoIndividualToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirTrabajadoresToolStripMenuItem,
            this.toolStripSeparator3,
            this.subirRolesToolStripMenuItem,
            this.toolStripSeparator4,
            this.utilidadesExcelToolStripMenuItem,
            this.toolStripSeparator5});
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.baseToolStripMenuItem.Text = "Base";
            // 
            // subirTrabajadoresToolStripMenuItem
            // 
            this.subirTrabajadoresToolStripMenuItem.Name = "subirTrabajadoresToolStripMenuItem";
            this.subirTrabajadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subirTrabajadoresToolStripMenuItem.Text = "Subir Trabajadores";
            this.subirTrabajadoresToolStripMenuItem.Click += new System.EventHandler(this.subirTrabajadoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // subirRolesToolStripMenuItem
            // 
            this.subirRolesToolStripMenuItem.Name = "subirRolesToolStripMenuItem";
            this.subirRolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subirRolesToolStripMenuItem.Text = "Subir Roles";
            this.subirRolesToolStripMenuItem.Click += new System.EventHandler(this.subirRolesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // utilidadesExcelToolStripMenuItem
            // 
            this.utilidadesExcelToolStripMenuItem.Name = "utilidadesExcelToolStripMenuItem";
            this.utilidadesExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilidadesExcelToolStripMenuItem.Text = "Utilidades Excel";
            this.utilidadesExcelToolStripMenuItem.Click += new System.EventHandler(this.utilidadesExcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormVentanaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVentanaRol";
            this.Text = "Roles TTHH";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correosMasivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem correoIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirTrabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem subirRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem utilidadesExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

