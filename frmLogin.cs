using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoRolesConCrystal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmsg, int wparm, int lparam);

        private void btnLogon_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO") {
                if (txtPass.Text != "CONTRASEÑA") {
                    DatosUsuarioSql user = new DatosUsuarioSql();
                    var validLogin = user.logonUser(txtUser.Text,txtPass.Text);
                    if (validLogin == true)
                    {
                        FormVentanaRol mainMenu = new FormVentanaRol();
                        MessageBox.Show("Bienvenido "+CacheLogon.FirstName+" "+CacheLogon.LastName,"Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        mainMenu.Show();
                        mainMenu.FormClosed += logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecta");
                    }
                }
                else msgError("Por favor ingrese su contraseña"); 
            }
            else msgError("Por favor ingrese su usuario");
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
                if(txtUser.Text == "USUARIO")
                {
                    txtUser.Text = "";
                    txtUser.ForeColor = ColorTranslator.FromHtml("#393d42");
                }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = ColorTranslator.FromHtml("#393d42");
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.Black;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void msgError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
        }
        private bool buttonPressed = false;
        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed=true;
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            txtPass.UseSystemPasswordChar = true;
        }

        private void logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "USUARIO";
            lblMensaje.Visible = false;
            this.Show();
            txtUser.Focus();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
