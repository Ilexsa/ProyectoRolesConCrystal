using ProyectoRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRolesConCrystal
{
    public partial class frmCargas : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);

        public frmCargas()
        {
            InitializeComponent();
        }
        
        private void txtPorcentajeD_Leave(object sender, EventArgs e)
        {
            int porcentajeIngresado = Convert.ToInt32(txtPorcentajeD.Text);
            if (porcentajeIngresado < 30)
            {
                MessageBox.Show("No cumple con el % minimo de discapacidad", "No califica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkDiscapacidad.Checked = false;
                cmbDiscapacidad.SelectedIndex = -1;
                txtPorcentajeD.Text = "";
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            ValidarCedula validarCedula = new ValidarCedula();
            bool verificarCedula = validarCedula.P_Valida_Cedula(txtCedula.Text);
            if (chkPasaporte.Checked == false)
            {
                if (verificarCedula == true)
                {
                    MessageBox.Show("Numero de cedula valido", "Cedula valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (verificarCedula == false)
            {
                txtCedula.Clear();
                MessageBox.Show("Numero de cedula no valido", "Cedula no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void frmCargas_Load(object sender, EventArgs e)
        {
            //List<KeyValuePair<string, string>> discapacidades = new List<KeyValuePair<string, string>>{
            //    new KeyValuePair<string, string>("1. Fisica" , "Fisica"),
            //    new KeyValuePair<string, string>("2. Intelectual" , "Intelectual"),
            //    new KeyValuePair<string, string>("3. Mental" , "Mental"),
            //    new KeyValuePair<string, string>("4. Psicosocial" , "Psicosocial"),
            //    new KeyValuePair<string, string>("5. Multiple" , "Multiple"),
            //    new KeyValuePair<string, string>("6. Sensorial" , "Sensorial"),
            //    new KeyValuePair<string, string>("7. Auditiva" , "Auditiva"),
            //    new KeyValuePair<string, string>("8. Visual" , "Visual")
            //};
            //cmbDiscapacidadCarga.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbDiscapacidadCarga.DataSource = discapacidades;
            //cmbDiscapacidadCarga.ValueMember = "Value";
            //cmbDiscapacidadCarga.DisplayMember = "Key";
            //List<KeyValuePair<string, string>> tipoCarga = new List<KeyValuePair<string, string>>{
            //    new KeyValuePair<string, string>("1. Conyuge" , "Conyuge"),
            //    new KeyValuePair<string, string>("2. Hijo/Hija" , "Hijo/Hija"),

            //};
            //cmbTipoCarga.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbTipoCarga.DataSource = tipoCarga;
            //cmbTipoCarga.ValueMember = "Value";
            //cmbTipoCarga.DisplayMember = "Key";
            //dtpFechaCarga.CustomFormat = "dd-MM-yyyy";
        }
        private void subirCargas()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ingresarCarga", conexion);
                cmd.CommandType= CommandType.StoredProcedure;
                frmSubirTrabajadores formSubirTrabajadores = new frmSubirTrabajadores();
                cmd.Parameters.AddWithValue("@CEDULA",formSubirTrabajadores.cedulaTrabajadorCarga);
                cmd.Parameters.AddWithValue("@TIPO_CARGA", cmbTipoCarga.SelectedValue);
                cmd.Parameters.AddWithValue("@APELLIDOS_NOMBRES_HIJO", txtNombres.Text);
                cmd.Parameters.AddWithValue("@CEDULA_HIJO", txtCedula.Text);
                cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO",dtpFechaNacimiento.Value);
                if (chkDiscapacidad.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@C_DISCAPACIDAD", 1); // Ingresa el valor de PER_DISCAPACIDAD (true/false)
                    cmd.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", Convert.ToInt32(txtPorcentajeD.Text)); // Ingresa el valor de PORCENTAJE_DISCAPACIDAD
                    cmd.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", cmbDiscapacidad.SelectedValue); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                else
                {
                    cmd.Parameters.AddWithValue("@C_DISCAPACIDAD", 0);
                    cmd.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", DBNull.Value);
                    cmd.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", DBNull.Value); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmbTipoCarga.SelectedValue.ToString()+" registrado con exito","Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value; //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            if (cmbTipoCarga.SelectedValue.ToString() == "Hijo/Hija" && edad >= 18)
            {
                MessageBox.Show("No se puede registrar a un hijo mayor de edad","Error");
                txtNombres.Clear();
                txtCedula.Clear();
            } 
            txtEdad.Text = edad.ToString();
        }

        private void chkDiscapacidad_CheckedChanged(object sender, EventArgs e)
        {
            txtPorcentajeD.Enabled = chkDiscapacidad.Checked;
            label10.Enabled = chkDiscapacidad.Checked;
            label11.Enabled = chkDiscapacidad.Checked;
            cmbDiscapacidad.Enabled = chkDiscapacidad.Checked;
        }

        private void btnSubirCarga_Click(object sender, EventArgs e)
        {
            subirCargas();
        }
    }
}
