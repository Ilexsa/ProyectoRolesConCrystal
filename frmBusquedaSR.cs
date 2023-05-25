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
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public partial class frmBusquedaSR : Form
    {
        SqlConnection conexion =new SqlConnection(ConexionBase.cadenaConexion);
        public frmBusquedaSR()
        {
            InitializeComponent();
        }
        public string cedulaSeleccionada { get; set; }
        private void frmBusquedaSR_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> querys = new List<KeyValuePair<string, string>>{
                new KeyValuePair<string, string>("NOMBRES" , "SELECT NOMBRES, CEDULA, CARGO FROM TRABAJADORES WHERE NOMBRES LIKE @PARAMETRO"),
                new KeyValuePair<string, string>("CEDULA" , "SELECT NOMBRES, CEDULA, CARGO FROM TRABAJADORES WHERE CEDULA LIKE @PARAMETRO"),
                new KeyValuePair<string, string>("CARGO" , "SELECT NOMBRES, CEDULA, CARGO FROM TRABAJADORES WHERE CARGO LIKE @PARAMETRO")
            };
            cmbOpcionesBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOpcionesBusqueda.DataSource = querys;
            cmbOpcionesBusqueda.DisplayMember = "Key";
            cmbOpcionesBusqueda.ValueMember = "Value";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadenaBusqueda = cmbOpcionesBusqueda.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(cadenaBusqueda,conexion);
            cmd.Parameters.AddWithValue("@PARAMETRO","%"+ txtBusqueda.Text + "%");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dgvResultadoBusqueda.DataSource = dataTable;
            conexion.Close();
        }

        private void dgvResultadoBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cedulaSeleccionada= dgvResultadoBusqueda.SelectedCells[1].Value.ToString();
            Close();
        }
    }
}
