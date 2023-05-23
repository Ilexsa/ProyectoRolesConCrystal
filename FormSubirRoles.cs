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
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public FormSubirRoles()
        {
            
            InitializeComponent();
        }

        private void FormSubirRoles_Load(object sender, EventArgs e)
        {
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

        private void btnAddN_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO TRABAJADORES VALUES (@CEDULA, @MATER_ENFG, @ALIMENTACION, @MOVILIZACION, @OTROS_INGRESOS_NA,@OTROS_INGRESOS_A, " +
                "@R_NOCTURNO, @R_NOCUTNO50, @R_NOCTURNO100, @EXTRAS, @INGRESOS_IESS,@T_INGRESOS, @A_QUINCENA, @P_QUIROGRAFARIOS, @P_HIPOTECARIOS, @DESCUENTO_PERMISOS_MEDICOS,@CxP, " +
                "@DESCUADRES, @SUPA, @EGRESOS_IESS, @T_EGRESOS, @NETO_RECIBIR, @MES_ROL,@SUELDO_DIAS_TRABAJADOS, @H_50, @H_100, @OTROS_DESCUENTOS, @ATRASOS)";
            SqlCommand comando = new SqlCommand(add,conexion);
            comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            comando.Parameters.AddWithValue("@MATER_ENFG", Convert.ToDouble(txtSubsidioEG.Text));
            comando.Parameters.AddWithValue("@ALIMENTACION", Convert.ToDouble(txtAlimentacion.Text));
            comando.Parameters.AddWithValue("@MOVILIZACION", Convert.ToDouble(txtMovilizacion.Text));
            comando.Parameters.AddWithValue("@OTROS_INGRESOS_NA", Convert.ToDouble(txtOtrosINA.Text));
            comando.Parameters.AddWithValue("@OTROS_INGRESOS_A", Convert.ToDouble(txtOtrosIA.Text));
            comando.Parameters.AddWithValue("@R_NOCTURNO", txtRNocturno);
            comando.Parameters.AddWithValue("@R_NOCUTNO50", txtRNocutno50);
            comando.Parameters.AddWithValue("@R_NOCTURNO100", txtRNocturno100);
            comando.Parameters.AddWithValue("@EXTRAS", txtExtras);
            comando.Parameters.AddWithValue("@INGRESOS_IESS", txtIngresosIESS);
            comando.Parameters.AddWithValue("@T_INGRESOS", txtTIngresos);
            comando.Parameters.AddWithValue("@A_QUINCENA", txtAQuincena);
            comando.Parameters.AddWithValue("@P_QUIROGRAFARIOS", txtPQuirografarios);
            comando.Parameters.AddWithValue("@P_HIPOTECARIOS", txtPHipotecarios);
            comando.Parameters.AddWithValue("@DESCUENTO_PERMISOS_MEDICOS", txtDescuentoPermisosMedicos);
            comando.Parameters.AddWithValue("@CxP", txtCxP);
            comando.Parameters.AddWithValue("@DESCUADRES", txtDescuadres);
            comando.Parameters.AddWithValue("@SUPA", txtSUPA);
            comando.Parameters.AddWithValue("@EGRESOS_IESS", txtEgresosIESS);
            comando.Parameters.AddWithValue("@T_EGRESOS", txtTEgresos);
            comando.Parameters.AddWithValue("@NETO_RECIBIR", txtNetoRecibir);
            comando.Parameters.AddWithValue("@MES_ROL", txtMesRol);
            comando.Parameters.AddWithValue("@SUELDO_DIAS_TRABAJADOS", txtSueldoDiasTrabajados);
            comando.Parameters.AddWithValue("@H_50", txtH50);
            comando.Parameters.AddWithValue("@H_100", txtH100);
            comando.Parameters.AddWithValue("@OTROS_DESCUENTOS", txtOtrosDescuentos);
            comando.Parameters.AddWithValue("@ATRASOS", txtAtrasos);

            comando.ExecuteNonQuery();
        }
    }
}
