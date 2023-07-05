using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.ModelBinding;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public partial class frmBusquedaSectoriales : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public string ID { get; set; }
        public string Sectorial { get; set; }
        public string sueldo { get; set; }
        public string cargo { get; set; }
        public frmBusquedaSectoriales()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (cmbTipoB.SelectedValue.ToString() == "SELECT ID_SECTORIAL AS 'ID', CARGO AS 'CARGO/ACTIVIDAD', CODIGO_IESS AS 'CÓDIGO IESS', " +
                "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL' FROM SECTORIALES WHERE ID_SECTORIAL LIKE @PARAMETRO")
                    {
                        try
                        {
                            conexion.Open();
                            string spSeñalado = cmbTipoB.SelectedValue.ToString();
                            SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                            cmd.Parameters.AddWithValue("@PARAMETRO", Convert.ToInt32(txtBuscar.Text));
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);
                            dgvResultado.DataSource = dataTable;
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
                        string spSeñalado = cmbTipoB.SelectedValue.ToString();
                        SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                        cmd.Parameters.AddWithValue("@PARAMETRO","%"+txtBuscar.Text+"%");
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        dgvResultado.DataSource = dataTable;
                        dgvResultado.RowHeadersVisible = false;
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmBusquedaSectoriales_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> querys = new List<KeyValuePair<string, string>>{
                new KeyValuePair<string, string>("CARGO" , "SELECT ID_SECTORIAL AS 'ID', CARGO AS 'CARGO/ACTIVIDAD', CODIGO_IESS AS 'CÓDIGO IESS', " +
                "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL' FROM SECTORIALES WHERE CARGO LIKE @PARAMETRO"),
                new KeyValuePair<string, string>("CODIGO DEL IESS" , "SELECT ID_SECTORIAL AS 'ID', CARGO AS 'CARGO/ACTIVIDAD', CODIGO_IESS AS 'CÓDIGO IESS', " +
                "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL' FROM SECTORIALES WHERE CODIGO_IESS LIKE  @PARAMETRO"),
                new KeyValuePair<string, string>("ID" , "SELECT ID_SECTORIAL AS 'ID', CARGO AS 'CARGO/ACTIVIDAD', CODIGO_IESS AS 'CÓDIGO IESS', " +
                "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL' FROM SECTORIALES WHERE ID_SECTORIAL LIKE @PARAMETRO")
            };
            cmbTipoB.DataSource = querys;
            cmbTipoB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoB.DisplayMember = "Key";
            cmbTipoB.ValueMember = "Value";
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dgvResultado.SelectedCells[0].Value.ToString();
            Sectorial = dgvResultado.SelectedCells[2].Value.ToString();
            cargo = dgvResultado.SelectedCells[1].Value.ToString();
            sueldo = dgvResultado.SelectedCells[3].Value.ToString();
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Length >= 3)
            {
                try
                {
                    if (cmbTipoB.SelectedValue.ToString() == "SELECT ID_SECTORIAL AS 'ID', CARGO AS 'CARGO/ACTIVIDAD', CODIGO_IESS AS 'CÓDIGO IESS', " +
                "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL' FROM SECTORIALES WHERE ID_SECTORIAL LIKE @PARAMETRO")
                    {
                        try
                        {
                            conexion.Open();
                            string spSeñalado = cmbTipoB.SelectedValue.ToString();
                            SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                            cmd.Parameters.AddWithValue("@PARAMETRO", Convert.ToInt32(txtBuscar.Text));
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);
                            dgvResultado.DataSource = dataTable;
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
                        string spSeñalado = cmbTipoB.SelectedValue.ToString();
                        SqlCommand cmd = new SqlCommand(spSeñalado, conexion);
                        cmd.Parameters.AddWithValue("@PARAMETRO", "%" + txtBuscar.Text + "%");
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        dgvResultado.DataSource = dataTable;
                        dgvResultado.RowHeadersVisible = false;
                        dgvResultado.KeyDown += evitarSalto;
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void evitarSalto(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ID = dgvResultado.SelectedCells[0].Value.ToString();
                Sectorial = dgvResultado.SelectedCells[2].Value.ToString();
                cargo = dgvResultado.SelectedCells[1].Value.ToString();
                sueldo = dgvResultado.SelectedCells[3].Value.ToString();
                Close();
            }
        }

        private void dgvResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Convert.ToInt32(Keys.Enter)))
            {
                ID = dgvResultado.SelectedCells[0].Value.ToString();
                Sectorial = dgvResultado.SelectedCells[2].Value.ToString();
                cargo = dgvResultado.SelectedCells[1].Value.ToString();
                sueldo = dgvResultado.SelectedCells[3].Value.ToString();
                Close();
            }
        }
    }
}