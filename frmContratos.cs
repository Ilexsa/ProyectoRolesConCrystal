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
    public partial class frmContratos : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public frmContratos()
        {
            InitializeComponent();
        }
        private void btnAggContrato_Click(object sender, EventArgs e)
        {
            agregarContrato(txtContratos.Text);
            cargarTabla();
        }
        private void frmContratos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void agregarContrato(string tipoContrato)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("sp_agregarContrato",conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CONTRATO",tipoContrato);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        private void cargarTabla ()
        {
            conexion.Open();
            string query = "SELECT * FROM TIPOS_CONTRATO ";
            SqlCommand sqlCommand = new SqlCommand(query, conexion);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable tabla = new DataTable();
            sqlDataAdapter.Fill(tabla);
            dgvContrato.DataSource = tabla;
            conexion.Close();
        }
    }
}
