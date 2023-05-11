using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRolesConCrystal
{
    public partial class FormVentanaRol : Form
    {
        public FormVentanaRol()
        {
            InitializeComponent();
        }

        private void correosMasivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCmasivos formCmasivos = new FormCmasivos();
            formCmasivos.ShowDialog();
        }

        private void correoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirRoles formSubirIndividdual = new FormSubirRoles();
            formSubirIndividdual.ShowDialog();
        }

        private void subirTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirTrabajadores formSubirTrabajadores = new FormSubirTrabajadores();
            formSubirTrabajadores.ShowDialog();
        }

        private void subirRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirRoles formSubirRoles= new FormSubirRoles();
            formSubirRoles.ShowDialog();
        }

        private void utilidadesExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtilidadesExcel formUtilidadesExcel = new FormUtilidadesExcel();
            formUtilidadesExcel.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el sistema?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
