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
            FormCIndividual formSubirIndividdual = new FormCIndividual();
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

        private void FormVentanaRol_Load(object sender, EventArgs e)
        {

        }

        private void tiposDeContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContratos frmContratos = new frmContratos();
            frmContratos.Show();
        }

        private void sectorialIESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectoriales frmSectoriales = new frmSectoriales();
            frmSectoriales.Show();
        }

        private void registrarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirTrabajadores formSubirTrabajadores = new FormSubirTrabajadores();
            formSubirTrabajadores.Show();
        }

        private void correosMasivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCmasivos formCmasivos = new FormCmasivos();
            formCmasivos.Show();
        }

        private void registrarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirRoles formSubirRoles = new FormSubirRoles();
            formSubirRoles.Show();
        }
    }
}
