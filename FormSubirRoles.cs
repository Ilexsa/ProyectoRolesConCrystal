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
using System.Data.SqlTypes;

namespace ProyectoRolesConCrystal
{
    public partial class FormSubirRoles : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        frmBusquedaSR busquedaSR = new frmBusquedaSR();
        public FormSubirRoles()
        {

            InitializeComponent();
        }

        private void FormSubirRoles_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string callLastR = "SELECT ID FROM NOMINA WHERE ID = (SELECT MAX(ID) FROM NOMINA)";
            SqlCommand comando = new SqlCommand(callLastR, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtNomina.Text = reader["ID"].ToString();
            }
            conexion.Close();

        }
        private void ObtenerIdBusqueda()
        {
            
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
            try
            {
                conexion.Open();
                string add = "INSERT INTO NOMINA (CEDULA, MATER_ENFG, ALIMENTACION, MOVILIZACION, OTROS_INGRESOS_NA, OTROS_INGRESOS_A, R_NOCTURNO, R_NOCUTNO50, R_NOCTURNO100, " +
                    "EXTRAS, INGRESOS_IESS, T_INGRESOS, A_QUINCENA, P_QUIROGRAFARIOS, P_HIPOTECARIOS, DESCUENTO_PERMISOS_MEDICOS, CxP, DESCUADRES, SUPA, EGRESOS_IESS, T_EGRESOS, " +
                    "NETO_RECIBIR, MES_ROL, SUELDO_DIAS_TRABAJADOS, H_50, H_100, OTROS_DESCUENTOS, ATRASOS, FONDOS_RESERVA) VALUES(@CEDULA, @MATER_ENFG, @ALIMENTACION, @MOVILIZACION," +
                    " @OTROS_INGRESOS_NA, @OTROS_INGRESOS_A, @R_NOCTURNO, @R_NOCUTNO50, @R_NOCTURNO100, @EXTRAS, @INGRESOS_IESS, @T_INGRESOS, @A_QUINCENA, @P_QUIROGRAFARIOS, " +
                    "@P_HIPOTECARIOS, @DESCUENTO_PERMISOS_MEDICOS, @CxP, @DESCUADRES, @SUPA, @EGRESOS_IESS, @T_EGRESOS, @NETO_RECIBIR, GETDATE(), @SUELDO_DIAS_TRABAJADOS, " +
                    "@H_50, @H_100, @OTROS_DESCUENTOS, @ATRASOS, @FONDOS_RESERVA)";
                //string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                SqlCommand comando = new SqlCommand(add, conexion);
                //comando.Parameters.AddWithValue("@ID",(Convert.ToInt32(txtNomina.Text)));
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@MATER_ENFG", (Convert.ToDouble(txtSubsidioEG.Text)));
                comando.Parameters.AddWithValue("@ALIMENTACION", (Convert.ToDouble(txtAlimentacion.Text)));
                comando.Parameters.AddWithValue("@MOVILIZACION", (Convert.ToDouble(txtMovilizacion.Text)));
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_NA", (Convert.ToDouble(txtOtrosINA.Text)));
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_A", (Convert.ToDouble(txtOtrosIA.Text)));
                comando.Parameters.AddWithValue("@R_NOCTURNO", (Convert.ToDouble(txtRNocturno.Text)));
                comando.Parameters.AddWithValue("@R_NOCUTNO50", 0);
                comando.Parameters.AddWithValue("@R_NOCTURNO100", 0);
                comando.Parameters.AddWithValue("@EXTRAS", 0);
                comando.Parameters.AddWithValue("@INGRESOS_IESS", 0);
                comando.Parameters.AddWithValue("@T_INGRESOS", (Convert.ToDouble(txtTotalIngresos.Text)));
                comando.Parameters.AddWithValue("@A_QUINCENA", (Convert.ToDouble(txtAnticipoSueldo.Text)));
                comando.Parameters.AddWithValue("@P_QUIROGRAFARIOS", (Convert.ToDouble(txtPrestamosQ.Text)));
                comando.Parameters.AddWithValue("@P_HIPOTECARIOS", (Convert.ToDouble(txtPrestamosH.Text)));
                comando.Parameters.AddWithValue("@DESCUENTO_PERMISOS_MEDICOS", (Convert.ToDouble(txtSubsidioEG.Text)));
                comando.Parameters.AddWithValue("@CxP", (Convert.ToDouble(txtConsumoPersonal.Text)));
                comando.Parameters.AddWithValue("@DESCUADRES", (Convert.ToDouble(txtDescuadres.Text)));
                comando.Parameters.AddWithValue("@SUPA", (Convert.ToDouble(txtSupa.Text)));
                comando.Parameters.AddWithValue("@EGRESOS_IESS", (Math.Round((Convert.ToDouble(txtTotalIngresos.Text) * 0.0945), 2)));
                comando.Parameters.AddWithValue("@T_EGRESOS", (Convert.ToDouble(txtTEgresos.Text)));
                comando.Parameters.AddWithValue("@NETO_RECIBIR", (Convert.ToDouble(txtNetoRecibir.Text)));
                //comando.Parameters.AddWithValue("@MES_ROL", DBNull.Value);
                comando.Parameters.AddWithValue("@SUELDO_DIAS_TRABAJADOS", (Convert.ToDouble(txtSueldoDT.Text)));
                comando.Parameters.AddWithValue("@H_50", (Convert.ToDouble(txtNumE50.Text)));
                comando.Parameters.AddWithValue("@H_100", (Convert.ToDouble(txtNumE100.Text)));
                comando.Parameters.AddWithValue("@OTROS_DESCUENTOS", (Convert.ToDouble(txtOtrosD.Text)));
                comando.Parameters.AddWithValue("@ATRASOS",((Convert.ToDouble(txtAtrasos.Text) * 0.25)));
                comando.Parameters.AddWithValue("@FONDOS_RESERVA", ((Convert.ToDouble(txtAtrasos.Text) * 0.25)));
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            busquedaSR.ShowDialog();
            string cedulaSeleccionada = busquedaSR.cedulaSeleccionada;
            txtCedula.Text = cedulaSeleccionada;
        }
        //private void leerDatosT()
        //{
        //    try
        //    {
        //        double vHorasExtras50;
        //        double vHorasExtras100;
        //        conexion.Open();
        //        SqlCommand command = new SqlCommand("sp_leerDatosTrabajador", conexion);
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //        command.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            txtEmpleado.Text = reader["NOMBRES"].ToString();
        //            txtCargoEmpleado.Text = reader["CARGO"].ToString();
        //            txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
        //            txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
        //            vHorasExtras50 = Convert.ToDouble(reader["H_E50"].ToString());
        //            vHorasExtras100 = Convert.ToDouble(reader["H_E100"].ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    conexion.Close();
        //}
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double vHorasExtras50;
                double vHorasExtras100;
                conexion.Open();
                SqlCommand command = new SqlCommand("sp_leerDatosTrabajador", conexion);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    txtEmpleado.Text = reader["NOMBRES"].ToString();
                    txtCargoEmpleado.Text = reader["CARGO"].ToString();
                    txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                    txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
                    vHorasExtras50 = Convert.ToDouble(reader["H_E50"].ToString());
                    vHorasExtras100 = Convert.ToDouble(reader["H_E100"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexion.Close();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //leerDatosT();
        }

        private void btnBuscarN_Click(object sender, EventArgs e)
        {
            frmBusquedaN frmBusquedaN = new frmBusquedaN();
            frmBusquedaN.ShowDialog();
            txtNomina.Text = frmBusquedaN.IdSeleccionado;
            txtCedula.Text = frmBusquedaN.cedulaSeleccionada;
        }

        private void txtNomina_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("sp_leerrOL", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtEmpleado.Text = reader["NOMBRES"].ToString();
                txtCargoEmpleado.Text = reader["CARGO"].ToString();
                txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
                txtEmpleado.Text = reader["NOMBRES"].ToString();
                txtCargoEmpleado.Text = reader["CARGO"].ToString();
                txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
                txtEmpleado.Text = reader["NOMBRES"].ToString();
                txtCargoEmpleado.Text = reader["CARGO"].ToString();
                txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
                txtEmpleado.Text = reader["NOMBRES"].ToString();
                txtCargoEmpleado.Text = reader["CARGO"].ToString();
                txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();
            }
        }
    }
}
