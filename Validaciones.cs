using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoRoles;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoRolesConCrystal
{
    public class Validaciones
    {
        public static bool validarCorreo(string correo)
        {
            // Utilizamos una expresión regular para verificar si el correo contiene al menos un símbolo "@"
            Regex regex = new Regex(@"@");
            Match match = regex.Match(correo);

            // Si se encuentra al menos una coincidencia, el correo es válido
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void validarNumero(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void validarTexto(object sender, KeyPressEventArgs e)
        {

            // Validar que solo se ingresen letras y admitir espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public static void validarSoloNumeroYpunto(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static bool validarCedulaDB(string cedula)
        {
            SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
            try
            {
                // Abrir la conexión
                conexion.Open();
                // Comando SQL para obtener todas las cédulas
                string sql = "SELECT CEDULA FROM TRABAJADORES";
                SqlCommand command = new SqlCommand(sql, conexion);

                // Ejecutar el comando y obtener el lector de datos
                SqlDataReader reader = command.ExecuteReader();

                // Recorrer todas las cédulas en la tabla
                while (reader.Read())
                {
                    string cedulaTabla = reader["CEDULA"].ToString();

                    // Validar si la cédula ingresada coincide con alguna en la tabla
                    if (cedula.Equals(cedulaTabla))
                    {
                        return false; // La cédula ya existe en la tabla
                    }
                }

                // Si se recorrieron todas las cédulas y no se encontró coincidencia, la cédula es válida
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
                return false; // Error al consultar la base de datos
            }
            finally
            {
                // Cerrar la conexión
                conexion.Close();
            }
        }
        public static bool validarCedulaDBC (string cedula)
        {
            SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
            try
            {
                // Abrir la conexión
                conexion.Open();
                // Comando SQL para obtener todas las cédulas
                string sql = "SELECT CEDULA_HIJO FROM CARGAS";
                SqlCommand command = new SqlCommand(sql, conexion);

                // Ejecutar el comando y obtener el lector de datos
                SqlDataReader reader = command.ExecuteReader();

                // Recorrer todas las cédulas en la tabla
                while (reader.Read())
                {
                    string cedulaTabla = reader["CEDULA_HIJO"].ToString();

                    // Validar si la cédula ingresada coincide con alguna en la tabla
                    if (cedula.Equals(cedulaTabla))
                    {
                        return false; // La cédula ya existe en la tabla
                    }
                }

                // Si se recorrieron todas las cédulas y no se encontró coincidencia, la cédula es válida
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
                return false; // Error al consultar la base de datos
            }
            finally
            {
                // Cerrar la conexión
                conexion.Close();
            }
        }
        public static void abrirCMB (ComboBox cmb, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!cmb.DroppedDown)
                {
                    cmb.DroppedDown = true; 
                    e.Handled = true;
                }
                else if (cmb.Items.Count > 0)
                {
                    int selectedIndex = cmb.SelectedIndex;

                    if (selectedIndex == -1)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        
                        if (e.KeyCode == Keys.Down)
                        {
                            selectedIndex = (selectedIndex + 1) % cmb.Items.Count;
                        }
                        else if (e.KeyCode == Keys.Up)
                        {
                            selectedIndex = (selectedIndex - 1 + cmb.Items.Count) % cmb.Items.Count;
                        }
                    }

                    cmb.SelectedIndex = selectedIndex; 
                    e.Handled = true;
                }
            }
        }
        public bool validarSueldoDown(double sueldo, int id)
        {
                using (var conexion = new SqlConnection(ConexionBase.cadenaConexion)) {
                    conexion.Open();
                     using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "SELECT SALARIO_MINIMO_SECTORIAL FROM SECTORIALES WHERE ID_SECTORIAL= @ID";
                        cmd.Parameters.AddWithValue("@ID",id);
                        SqlDataReader lector = cmd.ExecuteReader();
                        if (lector.Read())
                        {
                            double sueldoMin = lector.GetDouble(0);
                            if (sueldoMin > sueldo)
                            {
                                return false;
                            }else
                            {
                                return true;
                            }
                        }

                    }
                }return false;
        }
    }
}
