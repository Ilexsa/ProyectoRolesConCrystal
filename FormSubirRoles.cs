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
    public partial class FormSubirRoles : Form
    {
        public FormSubirRoles()
        {
            InitializeComponent();
        }

        private void FormSubirRoles_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
            conexion.Open();
            string callLastR = "SELECT ID FROM NOMINA WHERE ID = (SELECT MAX(ID) FROM NOMINA)";
            SqlCommand comando = new SqlCommand(callLastR,conexion);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtNomina.Text = reader["ID"].ToString();
            }

        }
        private int ObtenerUltimoID()
        {
            int lastID = 0;
            string query = "SELECT MAX(ID) FROM NOMINA";

            using (SqlConnection connection = new SqlConnection(ConexionBase.cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastID = Convert.ToInt32(result);
                }
            }
            return lastID;
        }

        private void btnNewN_Click(object sender, EventArgs e)
        {
            int ultimoID = ObtenerUltimoID();
            int nuevoID = ultimoID + 1;

            txtNomina.Text = nuevoID.ToString();
        }
    }
}
