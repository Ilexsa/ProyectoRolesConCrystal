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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoRolesConCrystal
{
    public partial class frmSectoriales : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public frmSectoriales()
        {
            InitializeComponent();
        }
        private void btnHabilitarEdicion_Click(object sender, EventArgs e)
        {
            habilitarEdicion();
        }
        private void frmSectoriales_Load(object sender, EventArgs e)
        {
            leerSectorial();
        }
        private void btnLastSectorial_Click(object sender, EventArgs e)
        {
            leerSectorial();
        }
        private void btnFirstSectorial_Click(object sender, EventArgs e)
        {
            leerFirtsSectorial();
        }
        private void btnPreviousSectorial_Click(object sender, EventArgs e)
        {
            leerPreviousSectorial(Convert.ToInt32(txtID.Text));
        }

        private void btnNextSectorial_Click(object sender, EventArgs e)
        {
            leerNextSectorial(Convert.ToInt32(txtID.Text));
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Enabled == true)
            {
                subirOActualizar(Convert.ToInt32(txtID.Text), txtCargo.Text, txtCodigoIESS.Text, txtEstructuraOcupacional.Text, Convert.ToDouble(txtSalarioMin.Text));
                habilitarEdicion();
            }
            else
            {
                MessageBox.Show("La edicion/creacion no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //<summary>
        //empieza los metodos
        //</summary>
        private void leerSectorial()
        {
            conexion.Open();
            try
            {
                string query = "SELECT TOP(1)" +
                               "ID_SECTORIAL AS 'ID'," +
                               "CODIGO_IESS AS 'CÓDIGO DEL IESS'," +
                               "CARGO AS 'CARGO/ACTIVIDAD'," +
                               "ESTRUCTURA_OCUPACIONAL AS 'ESTRUCTURA OCUPACIONAL'," +
                               "SALARIO_MINIMO_SECTORIAL AS 'SALARIO MINIMO SECTORIAL'" +
                               "FROM SECTORIALES " +
                               "ORDER BY ID_SECTORIAL DESC;";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtCodigoIESS.Text = dr["CÓDIGO DEL IESS"].ToString();
                    txtCargo.Text = dr["CARGO/ACTIVIDAD"].ToString();
                    txtSalarioMin.Text = dr["SALARIO MINIMO SECTORIAL"].ToString();
                    txtEstructuraOcupacional.Text = dr["ESTRUCTURA OCUPACIONAL"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }
        private void leerPreviousSectorial(int id)
        {
            conexion.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("sp_leerSectorialPrevious", conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("ID", id);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtCodigoIESS.Text = dr["CÓDIGO DEL IESS"].ToString();
                    txtCargo.Text = dr["CARGO/ACTIVIDAD"].ToString();
                    txtSalarioMin.Text = dr["SALARIO MINIMO SECTORIAL"].ToString();
                    txtEstructuraOcupacional.Text = dr["ESTRUCTURA OCUPACIONAL"].ToString();
                }
            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void leerFirtsSectorial()
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_leerSectorialFirst", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtCodigoIESS.Text = dr["CÓDIGO DEL IESS"].ToString();
                    txtCargo.Text = dr["CARGO/ACTIVIDAD"].ToString();
                    txtSalarioMin.Text = dr["SALARIO MINIMO SECTORIAL"].ToString();
                    txtEstructuraOcupacional.Text = dr["ESTRUCTURA OCUPACIONAL"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }
        private void leerNextSectorial(int id)
        {
            conexion.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("sp_leerSectorialNext", conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("ID", id);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtCodigoIESS.Text = dr["CÓDIGO DEL IESS"].ToString();
                    txtCargo.Text = dr["CARGO/ACTIVIDAD"].ToString();
                    txtSalarioMin.Text = dr["SALARIO MINIMO SECTORIAL"].ToString();
                    txtEstructuraOcupacional.Text = dr["ESTRUCTURA OCUPACIONAL"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSectoriales frmBusquedaSectoriales = new frmBusquedaSectoriales();
            frmBusquedaSectoriales.ShowDialog();
        }
        private void subirOActualizar(int id, string cargo, string codigo,string estructuraO, double salarioMin)
        {
            conexion.Open();
            try
            {
                SqlCommand command = new SqlCommand("sp_subirOActualizarSectorial", conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ID", id);
                command.Parameters.AddWithValue("CARGO",cargo);
                command.Parameters.AddWithValue("CODIGO_IESS",codigo);
                command.Parameters.AddWithValue("ESTRUCTURA_OCUPACIONAL",estructuraO);
                command.Parameters.AddWithValue("SALARIO_MINIMO_SECTORIAL",salarioMin);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro grabado/editado con exito", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        private void habilitarEdicion()
        {
            if(txtCargo.Enabled == false)
            {
                txtCargo.Enabled = true;
                txtCodigoIESS.Enabled = true;
                txtEstructuraOcupacional.Enabled = true;
                txtSalarioMin.Enabled = true;
            }
            else
            {
                txtCargo.Enabled = false;
                txtCodigoIESS.Enabled = false;
                txtEstructuraOcupacional.Enabled=false;
                txtSalarioMin.Enabled = false;
            }
        }
    }
}
