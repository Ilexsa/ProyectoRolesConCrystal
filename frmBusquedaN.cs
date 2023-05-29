using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public partial class frmBusquedaN : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public string IdSeleccionado { get; set; }
        public string cedulaSeleccionada { get; set; }
        public frmBusquedaN()
        {
            InitializeComponent();
        }

        private void frmBusquedaN_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> querys = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("ID","sp_BuscarNxId"),
                new KeyValuePair<string, string>("NOMBRES","sp_BuscarNxNombres"),
                new KeyValuePair<string, string>("CEDULA","sp_BuscarNxCedula")
            };
            cmbOpcionesB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOpcionesB.DataSource = querys;
            cmbOpcionesB.DisplayMember = "Key";
            cmbOpcionesB.ValueMember = "Value";
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter)) {
                try {
                    if (cmbOpcionesB.SelectedValue.ToString() == "sp_BuscarNxId") 
                    {
                        try
                        {
                            conexion.Open();
                            string spSeñalado = cmbOpcionesB.SelectedValue.ToString();
                            SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PARAMETRO",Convert.ToInt32(txtBusqueda.Text));
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);
                            dgvResultadoBusqueda.DataSource = dataTable;
                            conexion.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conexion.Close();
                    }
                    else
                    {
                        conexion.Open();
                        string spSeñalado = cmbOpcionesB.SelectedValue.ToString();
                        SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PARAMETRO", txtBusqueda.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        dgvResultadoBusqueda.DataSource = dataTable;
                        conexion.Close();
                    }
                    } catch(Exception ex) {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvResultadoBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdSeleccionado = dgvResultadoBusqueda.SelectedCells[0].Value.ToString();
            cedulaSeleccionada = dgvResultadoBusqueda.SelectedCells[2].Value.ToString();
            Close();
        }
    }
}
