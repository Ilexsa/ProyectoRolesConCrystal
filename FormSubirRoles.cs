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
using Microsoft.Identity.Client;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Org.BouncyCastle.Crypto.Engines;
using System.IO;

namespace ProyectoRolesConCrystal
{
    public partial class FormSubirRoles : Form
    {

        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        decimal sueldoXdia = 0;
        decimal hN = 0;
        decimal he50 = 0;
        decimal he100 = 0;
        decimal tIngresos = 0;
        decimal tEgresos = 0;
        decimal valorAtrasos= 0;
        decimal valorHN = 0;
        decimal valorHE50 = 0;
        decimal valorHE100 = 0;
        decimal valorIESS = 0;
        decimal netoRecibir = 0;
        decimal valorFR = 0;
        decimal valorIA = 0;
        decimal valorINA = 0;
        decimal valorAlimentacion = 0;
        decimal valorMovilizacion = 0;
        decimal anticipoS = 0;
        decimal prestamosQ = 0;
        decimal prestamosH = 0;
        decimal otrosDescuentos = 0;
        decimal consumosP = 0;
        decimal subsidiosMater = 0;
        decimal subsidiosEnfer = 0;
        decimal descuadres = 0;
        decimal supa = 0;
        Validaciones validaciones = new Validaciones();
        public FormSubirRoles()
        {
            InitializeComponent();
            agregar0();
            KeyPreview = true ;
        }
        private void txtSueldoDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSueldoDT.Text != "")
            {
                if (validaciones.validarDiasT(Convert.ToInt32(txtSueldoDT.Text)) == false)
                {
                    MessageBox.Show("No se puede ingresar dias adiconales", "Error");
                    txtSueldoDT.Text = "30";
                }
                decimal calculoSueldoxDia = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia, 2);
                txtTotalIngresos.Text = (calculoSueldoxDia).ToString();
            }
        }

        private void txtTotalIngresos_TextChanged(object sender, EventArgs e)
        {
            decimal iess = Math.Round((Convert.ToDecimal(txtTotalIngresos.Text)-(valorFR+valorINA + valorMovilizacion + valorAlimentacion)) * 0.0945m, 2);
            valorIESS = iess;
            txtIESS.Text = iess.ToString();
            tIngresos = Convert.ToDecimal(txtTotalIngresos.Text); 
            txtNetoRecibir.Text = Convert.ToString(tIngresos - tEgresos);
        }

        private void txtRNocturno_TextChanged(object sender, EventArgs e)
        {
            if (txtRNocturno.Text != "")
            {
                decimal calculoHN = Math.Round(Convert.ToDecimal(txtRNocturno.Text) * hN, 2);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + calculoHN + valorHE100 + valorHE50 + valorIA
                + valorINA + valorFR + valorAlimentacion + valorMovilizacion, 2).ToString();
                valorHN = calculoHN;
            }
        }

        private void txtNumE50_TextChanged(object sender, EventArgs e)
        {
            if (txtNumE50.Text != "")
            {
                decimal calculoHN = Math.Round(Convert.ToDecimal(txtNumE50.Text) * he50, 2);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + calculoHN + valorHE100 + valorHN + valorIA
                + valorINA + valorFR + valorAlimentacion + valorMovilizacion, 2).ToString();
                valorHE50 = calculoHN;
            }
        }

        private void txtNumE100_TextChanged(object sender, EventArgs e)
        {
            if (txtNumE100.Text != "")
            {
                decimal calculoHN = Math.Round(Convert.ToDecimal(txtNumE100.Text) * he100, 2);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + calculoHN + valorHE50 + valorHN + valorIA
                + valorINA + valorFR + valorAlimentacion + valorMovilizacion, 2).ToString();
                valorHE100 = calculoHN;
            }
        }

        private void txtAtrasos_TextChanged(object sender, EventArgs e)
        {
            if (txtAtrasos.Text != "")
            {
                decimal calculoHN = Math.Round(Convert.ToDecimal(txtAtrasos.Text) * 0.25m, 2);
                valorAtrasos = calculoHN;
                txtTEgresos.Text = (valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa).ToString();
                
            }
        }

        private void txtIESS_TextChanged(object sender, EventArgs e)
        {
            if (txtIESS.Text != "")
            {
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtSueldoDT_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
        }

        private void txtSueldoDT_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }
        private void FormSubirRoles_Load(object sender, EventArgs e)
        {
            MostrarLastCedula();
            MostrarLastID();
        }
        private void MostrarLastCedula()
        {
            conexion.Open();
            try
            {
                string callLastR = "SELECT ID, CEDULA FROM NOMINA WHERE ID = (SELECT MAX(ID) FROM NOMINA)";
                SqlCommand comando = new SqlCommand(callLastR, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtCedula.Text = lector["CEDULA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                conexion.Close();
            }
        }
        private void MostrarLastID()
        {
            conexion.Open();
            try
            {
                string callLastR = "SELECT ID, CEDULA FROM NOMINA WHERE ID = (SELECT MAX(ID) FROM NOMINA)";
                SqlCommand comando = new SqlCommand(callLastR, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtNomina.Text = lector["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                conexion.Close();
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
                connection.Close();
            }
            return lastID;
        }

        private void btnNewN_Click(object sender, EventArgs e)
        {
            int ultimoID = ObtenerUltimoID();
            int nuevoID = ultimoID + 1;
            txtNomina.Text = nuevoID.ToString();
            limpiarTxts();
        }

        private void btnAddN_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de los datos para el registro del rol?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                agregarRol();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmBusquedaSR busquedaSR = new frmBusquedaSR();
            busquedaSR.ShowDialog();
            string cedulaSeleccionada = busquedaSR.cedulaSeleccionada;
            txtCedula.Text = cedulaSeleccionada;
            DatosParaNomina.datosNomina(txtCedula.Text);
            sueldoXdia = DatosParaNomina.sueldoXdia;
            hN = DatosParaNomina.horaN;
            he50 = DatosParaNomina.he50;
            he100 = DatosParaNomina.he100;
            decimal calculoSueldoxDia = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia, 2);
            txtTotalIngresos.Text = calculoSueldoxDia.ToString();
            txtAnticipoSueldo.Text = Math.Round(sueldoXdia * 30m * 0.40m, 2).ToString();
        }
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            conexion.Close();
            try
            {
                conexion.Open();
                SqlCommand comandoLT = new SqlCommand("sp_leerDatosTrabajador", conexion);
                comandoLT.CommandType = System.Data.CommandType.StoredProcedure;
                comandoLT.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                SqlDataReader reader = comandoLT.ExecuteReader();
                if (reader.Read())
                {
                    txtEmpleado.Text = reader["NOMBRES"].ToString();
                    txtCargoEmpleado.Text = reader["CARGO"].ToString();
                    txtFechaIngEm.Text = reader["FECHA_INGRESO"].ToString();
                    txtSueldoEmpleado.Text = reader["SUELDO_BASE"].ToString();

                }
                DatosParaNomina.datosNomina(txtCedula.Text);
                sueldoXdia = DatosParaNomina.sueldoXdia;
                hN = DatosParaNomina.horaN;
                he50 = DatosParaNomina.he50;
                he100 = DatosParaNomina.he100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
         
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
            conexion.Close();
            try
            {
                conexion.Open();
                Tuple<double, double> valoresH = GetHorasExtras(txtCedula.Text);
                double h50 = valoresH.Item1;
                double h100 = valoresH.Item2;
                SqlCommand comandoLR = new SqlCommand("sp_leerRol", conexion);
                comandoLR.CommandType = System.Data.CommandType.StoredProcedure;
                comandoLR.Parameters.AddWithValue("@ID_ROL", Convert.ToInt32(txtNomina.Text));
                SqlDataReader lectorr = comandoLR.ExecuteReader();
                if (lectorr.Read())
                {
                    txtSueldoDT.Text = lectorr["SUELDO_DIAS_TRABAJADOS"].ToString();
                    txtRNocturno.Text = lectorr["R_NOCTURNO"].ToString();
                    txtNumE50.Text = lectorr["H_50"].ToString();
                    txtNumE100.Text = lectorr["H_100"].ToString();
                    txtFondosR.Text = lectorr["FONDOS_RESERVA"].ToString();
                    txtOtrosIA.Text = lectorr["OTROS_INGRESOS_A"].ToString();
                    txtOtrosINA.Text = lectorr["OTROS_INGRESOS_NA"].ToString();
                    txtAlimentacion.Text = lectorr["ALIMENTACION"].ToString();
                    txtMovilizacion.Text = lectorr["MOVILIZACION"].ToString();
                    txtAnticipoSueldo.Text = lectorr["A_QUINCENA"].ToString();
                    txtPrestamosQ.Text = lectorr["P_QUIROGRAFARIOS"].ToString();
                    txtPrestamosH.Text = lectorr["P_HIPOTECARIOS"].ToString();
                    txtOtrosD.Text = lectorr["OTROS_DESCUENTOS"].ToString();
                    txtConsumoPersonal.Text = lectorr["CxP"].ToString();
                    txtSubsidioM.Text = lectorr["MATER_ENFG"].ToString();
                    txtSubsidioEG.Text = lectorr["DESCUENTO_PERMISOS_MEDICOS"].ToString();
                    txtDescuadres.Text = lectorr["DESCUADRES"].ToString();
                    txtSupa.Text = lectorr["SUPA"].ToString();
                    txtAtrasos.Text = lectorr["ATRASOS"].ToString();
                    txtIESS.Text = lectorr["EGRESOS_IESS"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void btnUltimaN_Click(object sender, EventArgs e)
        {
            MostrarLastID();
            MostrarLastCedula();
        }
        private void mostrarFirtsID()
        {
            conexion.Open();
            try
            {
                string consulta = "SELECT ID FROM NOMINA WHERE ID=(SELECT MIN(ID) FROM NOMINA)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtNomina.Text = reader["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarFirtsCedula()
        {
            conexion.Open();
            try
            {
                string consulta = "SELECT CEDULA FROM NOMINA WHERE ID=(SELECT MIN(ID) FROM NOMINA)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtNomina.Text = reader["CEDULA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarNextId()
        {
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("sp_NextID", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtNomina.Text));
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtNomina.Text = reader["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void mostrarNextCedula()
        {
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("sp_NextID", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtNomina.Text));
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtCedula.Text = reader["CEDULA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void mostrarPreviousID()
        {
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("sp_previousID", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtNomina.Text));
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtNomina.Text = reader["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void mostrarPreviousCedula()
        {
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("sp_previousID", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtNomina.Text));
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtCedula.Text = reader["CEDULA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void btnEditarN_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el rol?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                actualizarRol();
            }
        }
        private void agregarRol()
        {
            try
            {
                Tuple<double, double> horasExtras = GetHorasExtras(txtCedula.Text);
                double h50 = horasExtras.Item1;
                double h100 = horasExtras.Item2;
                SqlCommand comando = new SqlCommand("sp_registrarRol", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtNomina.Text));
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@SUELDO_DT", Convert.ToDecimal(txtSueldoDT.Text));
                comando.Parameters.AddWithValue("@RECARGO_N", Convert.ToDecimal(txtRNocturno.Text));
                comando.Parameters.AddWithValue("@H_E50", valorHE50);
                comando.Parameters.AddWithValue("@H_E100", valorHE100);
                comando.Parameters.AddWithValue("@FONDOS_RESERVA", valorFR);
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_APORTABLES", valorIA);
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_NAPORTABLES", valorINA);
                comando.Parameters.AddWithValue("@ALIMENTACION", valorAlimentacion);
                comando.Parameters.AddWithValue("@MOVILIZACION", valorMovilizacion);
                comando.Parameters.AddWithValue("@TOTAL_INGRESOS", tIngresos);
                comando.Parameters.AddWithValue("@ANTICIPO_SUELDO", anticipoS);
                comando.Parameters.AddWithValue("@PRESTAMOS_Q", prestamosQ);
                comando.Parameters.AddWithValue("@PRESTAMOS_H", prestamosH);
                comando.Parameters.AddWithValue("@OTROS_DESCUENTOS", otrosDescuentos);
                comando.Parameters.AddWithValue("@CxP", consumosP);
                comando.Parameters.AddWithValue("@SUBSIDIOS_MATER", subsidiosMater);
                comando.Parameters.AddWithValue("@SUBISIDIOS_ENFER", subsidiosEnfer);
                comando.Parameters.AddWithValue("@DESCUADRES", descuadres);
                comando.Parameters.AddWithValue("@SUPA", supa);
                comando.Parameters.AddWithValue("@ATRASOS", valorAtrasos);
                comando.Parameters.AddWithValue("IESS", valorIESS);
                comando.Parameters.AddWithValue("TOTAL_EGRESOS", tEgresos);
                comando.Parameters.AddWithValue("NETO_RECIBIR", netoRecibir);
                comando.ExecuteNonQuery();
                MessageBox.Show("RegistrO exitoso", "Rol subido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }
        private void limpiarTxts()
        {
            //txtCedula.Text = "0";
            txtAlimentacion.Text = "0";
            //txtAnticipoSueldo.Text = "0";
            //txtCargoEmpleado.Text = "0";
            //txtTotalIngresos.Text = "0";
            txtAtrasos.Text = "0";
            txtConsumoPersonal.Text = "0";
            txtDescuadres.Text = "0";
            //txtEmpleado.Text = "0";
            //txtFechaIngEm.Text = "0";
            txtFondosR.Text = "0";
            //txtIESS.Text = "0";
            txtMovilizacion.Text = "0";
            //txtNetoRecibir.Text = "0";
            txtNumE100.Text = "0";
            txtNumE50.Text = "0";
            txtOtrosD.Text = "0";
            txtOtrosIA.Text = "0";
            txtOtrosINA.Text = "0";
            txtPrestamosH.Text = "0";
            txtPrestamosQ.Text = "0";
            txtRNocturno.Text = "0";
            txtSubsidioEG.Text = "0";
            txtSubsidioM.Text = "0";
            //txtSueldoDT.Text = "0";
            //txtSueldoEmpleado.Text = "0";
            txtSupa.Text = "0";
            //txtTEgresos.Text = "0";
            //txtTotalIngresos.Text = "0";
        }
        private void btnPrimerN_Click(object sender, EventArgs e)
        {
            mostrarFirtsCedula();
            mostrarFirtsID();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            mostrarNextCedula();
            mostrarNextId();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            mostrarPreviousCedula();
            mostrarPreviousID();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GenerarReportes generarPdfs = new GenerarReportes();
            try
            {
                generarPdfs.generarPDFS();
                MessageBox.Show("Se han generado los roles individuales correctamente", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Tuple<double, double> GetHorasExtras(string cedula)
        {
            double hora50 = 0;
            double hora100 = 0;
            string query = "SELECT H_E50, H_E100 FROM TRABAJADORES WHERE CEDULA = @CEDULA";
            conexion.Close();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@CEDULA", cedula);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                hora50 = Convert.ToDouble(reader["H_E50"].ToString());
                hora100 = Convert.ToDouble(reader["H_E100"].ToString());
            }
            reader.Close();
            return new Tuple<double, double>(hora50, hora100);
        }
        private void actualizarRol()
        {
            try
            {
                Tuple<double, double> horasExtras = GetHorasExtras(txtCedula.Text);
                double h50 = horasExtras.Item1;
                double h100 = horasExtras.Item2;
                SqlCommand comando = new SqlCommand("sp_modificarRol", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtNomina.Text));
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@SUELDO_DT", Convert.ToDouble(txtSueldoDT.Text));
                comando.Parameters.AddWithValue("@RECARGO_N", Convert.ToDouble(txtRNocturno.Text));
                comando.Parameters.AddWithValue("@H_E50", Math.Round((Convert.ToDouble(txtNumE50.Text)) * h50, 2));
                comando.Parameters.AddWithValue("@H_E100", Math.Round((Convert.ToDouble(txtNumE100.Text)) * h100, 2));
                comando.Parameters.AddWithValue("@FONDOS_RESERVA", Convert.ToDouble(txtFondosR.Text));
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_APORTABLES", Convert.ToDouble(txtOtrosIA.Text));
                comando.Parameters.AddWithValue("@OTROS_INGRESOS_NAPORTABLES", Convert.ToDouble(txtOtrosINA.Text));
                comando.Parameters.AddWithValue("@ALIMENTACION", Convert.ToDouble(txtAlimentacion.Text));
                comando.Parameters.AddWithValue("@MOVILIZACION", Convert.ToDouble(txtMovilizacion.Text));
                comando.Parameters.AddWithValue("@TOTAL_INGRESOS", tIngresos);
                comando.Parameters.AddWithValue("@ANTICIPO_SUELDO", Convert.ToDouble(txtAnticipoSueldo.Text));
                comando.Parameters.AddWithValue("@PRESTAMOS_Q", Convert.ToDouble(txtPrestamosQ.Text));
                comando.Parameters.AddWithValue("@PRESTAMOS_H", Convert.ToDouble(txtPrestamosH.Text));
                comando.Parameters.AddWithValue("@OTROS_DESCUENTOS", Convert.ToDouble(txtOtrosD.Text));
                comando.Parameters.AddWithValue("@CxP", Convert.ToDouble(txtConsumoPersonal.Text));
                comando.Parameters.AddWithValue("@SUBSIDIOS_MATER", Convert.ToDouble(txtSubsidioM.Text));
                comando.Parameters.AddWithValue("@SUBSIDIOS_ENFER", Convert.ToDouble(txtSubsidioEG.Text));
                comando.Parameters.AddWithValue("@DESCUADRES", Convert.ToDouble(txtDescuadres.Text));
                comando.Parameters.AddWithValue("@SUPA", Convert.ToDouble(txtSupa.Text));
                comando.Parameters.AddWithValue("@ATRASOS", Math.Round((Convert.ToDouble(txtAtrasos.Text)) * 0.25, 2));
                comando.Parameters.AddWithValue("IESS", Convert.ToDouble(txtIESS.Text));
                comando.Parameters.AddWithValue("TOTAL_EGRESOS", Convert.ToDouble(txtTEgresos.Text));
                comando.Parameters.AddWithValue("NETO_RECIBIR", Convert.ToDouble(txtNetoRecibir.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Modificacion realizada con exito", "¡Rol Modificado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();

        }
        private void agregar0()
        {
            txtIESS.Enter += txtSueldoDT_Enter;
            txtIESS.Leave += txtSueldoDT_Leave;

            txtAtrasos.Enter += txtSueldoDT_Enter;
            txtAtrasos.Leave += txtSueldoDT_Leave;

            txtSupa.Enter += txtSueldoDT_Enter;
            txtSupa.Leave += txtSueldoDT_Leave;

            txtDescuadres.Enter += txtSueldoDT_Enter;
            txtDescuadres.Leave += txtSueldoDT_Leave;

            txtSubsidioEG.Enter += txtSueldoDT_Enter;
            txtSubsidioEG.Leave += txtSueldoDT_Leave;

            txtSubsidioM.Enter += txtSueldoDT_Enter;
            txtSubsidioM.Leave += txtSueldoDT_Leave;

            txtOtrosD.Enter += txtSueldoDT_Enter;
            txtOtrosD.Leave += txtSueldoDT_Leave;

            txtConsumoPersonal.Enter += txtSueldoDT_Enter;
            txtConsumoPersonal.Leave += txtSueldoDT_Leave;

            txtPrestamosH.Enter += txtSueldoDT_Enter;
            txtPrestamosH.Leave += txtSueldoDT_Leave;

            txtAnticipoSueldo.Enter += txtSueldoDT_Enter;
            txtAnticipoSueldo.Leave += txtSueldoDT_Leave;

            txtPrestamosQ.Enter += txtSueldoDT_Enter;
            txtPrestamosQ.Leave += txtSueldoDT_Leave;

            txtCargoEmpleado.Enter += txtSueldoDT_Enter;
            txtCargoEmpleado.Leave += txtSueldoDT_Leave;

            txtTEgresos.Enter += txtSueldoDT_Enter;
            txtTEgresos.Leave += txtSueldoDT_Leave;

            txtNetoRecibir.Enter += txtSueldoDT_Enter;
            txtNetoRecibir.Leave += txtSueldoDT_Leave;

            txtTotalIngresos.Enter += txtSueldoDT_Enter;
            txtTotalIngresos.Leave += txtSueldoDT_Leave;

            txtMovilizacion.Enter += txtSueldoDT_Enter;
            txtMovilizacion.Leave += txtSueldoDT_Leave;

            txtAlimentacion.Enter += txtSueldoDT_Enter;
            txtAlimentacion.Leave += txtSueldoDT_Leave;

            txtOtrosINA.Enter += txtSueldoDT_Enter;
            txtOtrosINA.Leave += txtSueldoDT_Leave;

            txtOtrosIA.Enter += txtSueldoDT_Enter;
            txtOtrosIA.Leave += txtSueldoDT_Leave;

            txtNumE100.Enter += txtSueldoDT_Enter;
            txtNumE100.Leave += txtSueldoDT_Leave;

            txtFondosR.Enter += txtSueldoDT_Enter;
            txtFondosR.Leave += txtSueldoDT_Leave;

            txtNumE50.Enter += txtSueldoDT_Enter;
            txtNumE50.Leave += txtSueldoDT_Leave;

            txtSueldoDT.Enter += txtSueldoDT_Enter;
            txtSueldoDT.Leave += txtSueldoDT_Leave;

            txtRNocturno.Enter += txtSueldoDT_Enter;
            txtRNocturno.Leave += txtSueldoDT_Leave;

            txtNomina.Enter += txtSueldoDT_Enter;
            txtNomina.Leave += txtSueldoDT_Leave;
            txtIESS.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtAtrasos.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtSupa.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtDescuadres.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtSubsidioEG.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtSubsidioM.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtOtrosD.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtConsumoPersonal.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtPrestamosH.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtAnticipoSueldo.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtPrestamosQ.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtCargoEmpleado.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtTEgresos.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtNetoRecibir.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtTotalIngresos.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtMovilizacion.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtAlimentacion.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtOtrosINA.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtOtrosIA.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtNumE100.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtFondosR.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtNumE50.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtSueldoDT.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtRNocturno.KeyPress += Validaciones.validarSoloNumeroYpunto;
            txtNomina.KeyPress += Validaciones.validarSoloNumeroYpunto; 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSR busquedaSR = new frmBusquedaSR();
            busquedaSR.ShowDialog();
            string cedulaSeleccionada = busquedaSR.cedulaSeleccionada;
            txtCedula.Text = cedulaSeleccionada;
            DatosParaNomina.datosNomina(txtCedula.Text);
            sueldoXdia = DatosParaNomina.sueldoXdia;
            hN = DatosParaNomina.horaN;
            he50 = DatosParaNomina.he50;
            he100 = DatosParaNomina.he100;
            decimal calculoSueldoxDia = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia, 2);
            txtTotalIngresos.Text = calculoSueldoxDia.ToString();
            txtAnticipoSueldo.Text = Math.Round(sueldoXdia * 30m * 0.40m, 2).ToString();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de los datos para el registro del rol?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                agregarRol();
            }
        }

        private void FormSubirRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) // Atajo F1 para guardar registros
            {
                //habilitarEdicion();
                //limpiarCanmpos();
            }

            if (e.Control && e.KeyCode == Keys.G) // Atajo Ctrl+S para guardar registros
            {
                if (txtCedula.Enabled == true)
                {
                    //aggTrabajador();
                }
                else
                {
                    MessageBox.Show("La edicion/creacion no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (e.Control && e.KeyCode == Keys.E) // Atajo Ctrl+S para guardar registros
            {
                //habilitarEdicion();
            }
            if (e.Control && e.KeyCode == Keys.B) // Atajo Ctrl+S para guardar registros
            {
                frmBusquedaSR busquedaSR = new frmBusquedaSR();
                busquedaSR.ShowDialog();
                string cedulaSeleccionada = busquedaSR.cedulaSeleccionada;
                txtCedula.Text = cedulaSeleccionada;
                DatosParaNomina.datosNomina(txtCedula.Text);
                sueldoXdia = DatosParaNomina.sueldoXdia;
                hN = DatosParaNomina.horaN;
                he50 = DatosParaNomina.he50;
                he100 = DatosParaNomina.he100;
                decimal calculoSueldoxDia = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia, 2);
                txtTotalIngresos.Text = calculoSueldoxDia.ToString();
                txtAnticipoSueldo.Text = Math.Round(sueldoXdia * 30m * 0.40m, 2).ToString();
            }
        }

        private void txtTEgresos_TextChanged(object sender, EventArgs e)
        {
            tEgresos = Convert.ToDecimal(txtTEgresos.Text);
            txtNetoRecibir.Text = Convert.ToString(tIngresos - tEgresos);
        }

        private void txtFondosR_TextChanged(object sender, EventArgs e)
        {
            if (txtFondosR.Text != "")
            {
                valorFR = Convert.ToDecimal(txtFondosR.Text);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + valorFR + valorHE100 + valorHE50 + valorHN +valorIA 
                + valorINA, 2).ToString();
            }
        }

        private void txtOtrosIA_TextChanged(object sender, EventArgs e)
        {
            if (txtOtrosIA.Text != "")
            {
                valorIA = Convert.ToDecimal(txtOtrosIA.Text);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + valorFR + valorHE100 + valorHE50 + valorHN + valorIA 
                + valorINA, 2).ToString();
            }
        }

        private void txtOtrosINA_TextChanged(object sender, EventArgs e)
        {
            if (txtOtrosINA.Text != "")
            {
                valorINA = Convert.ToDecimal(txtOtrosINA.Text);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + valorFR + valorHE100 + valorHE50 + valorHN + valorIA
                + valorINA, 2).ToString();
            }
        }

        private void txtAlimentacion_TextChanged(object sender, EventArgs e)
        {
            if (txtAlimentacion.Text != "")
            {
                valorAlimentacion = Convert.ToDecimal(txtAlimentacion.Text);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + valorFR + valorHE100 + valorHE50 + valorHN + valorIA
                + valorINA + valorAlimentacion + valorMovilizacion, 2).ToString();
            }
        }

        private void txtMovilizacion_TextChanged(object sender, EventArgs e)
        {
            if (txtMovilizacion.Text != "")
            {
                valorMovilizacion = Convert.ToDecimal(txtMovilizacion.Text);
                txtTotalIngresos.Text = Math.Round(Convert.ToDecimal(txtSueldoDT.Text) * sueldoXdia + valorFR + valorHE100 + valorHE50 + valorHN + valorIA
                + valorINA + valorAlimentacion + valorMovilizacion, 2).ToString();
            }
        }

        private void txtAnticipoSueldo_TextChanged(object sender, EventArgs e)
        {
            if (txtAnticipoSueldo.Text != "")
            {
                anticipoS = Convert.ToDecimal(txtAnticipoSueldo.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtPrestamosQ_TextChanged(object sender, EventArgs e)
        {
            if (txtPrestamosQ.Text != "")
            {
                prestamosQ = Convert.ToDecimal(txtPrestamosQ.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtPrestamosH_TextChanged(object sender, EventArgs e)
        {
            if (txtPrestamosH.Text != "")
            {
                prestamosH = Convert.ToDecimal(txtPrestamosH.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtOtrosD_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                otrosDescuentos = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtConsumoPersonal_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                consumosP = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtSubsidioM_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                subsidiosMater = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtSubsidioEG_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                subsidiosEnfer = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtDescuadres_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                descuadres = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void txtSupa_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                supa = Convert.ToDecimal(textBox.Text);
                txtTEgresos.Text = Convert.ToString(valorAtrasos + valorIESS + anticipoS + prestamosQ + prestamosH + otrosDescuentos
                    + consumosP + subsidiosEnfer + subsidiosMater + descuadres + supa);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTxts();
        }
    }
}