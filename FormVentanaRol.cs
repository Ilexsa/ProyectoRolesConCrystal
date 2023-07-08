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
            this.IsMdiContainer = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el sesión?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void FormVentanaRol_Load(object sender, EventArgs e)
        {
            lblUser.Text = CacheLogon.LoginName;
            lblName.Text = CacheLogon.FirstName + " " + CacheLogon.LastName;
            lblKindUser.Text = CacheLogon.Position;
        }

        private void tiposDeContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContratos frmContratos = new frmContratos();
            frmContratos.MdiParent = this;
            frmContratos.Show();
        }

        private void sectorialIESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectoriales frmSectoriales = new frmSectoriales();
            frmSectoriales.MdiParent = this;
            frmSectoriales.Show();
        }

        private void registrarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubirTrabajadores formSubirTrabajadores = new frmSubirTrabajadores();
            formSubirTrabajadores.MdiParent = this;
            formSubirTrabajadores.Show();
        }

        private void correosMasivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCmasivos formCmasivos = new FormCmasivos();
            formCmasivos.MdiParent = this;
            formCmasivos.Show();
        }

        private void registrarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirRoles formSubirRoles = new FormSubirRoles();
            formSubirRoles.MdiParent = this;
            formSubirRoles.Show();
        }
    }
}