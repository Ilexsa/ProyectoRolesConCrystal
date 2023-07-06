using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using ProyectoRoles;
using System.Windows.Forms;

namespace ProyectoRolesConCrystal
{
    public class DatosParaNomina
    {
        public static decimal sueldoXdia { get; set; }
        public static decimal horaN { get; set; }
        public static decimal he50 { get; set; }
        public static decimal he100 { get; set; }
        
        public static void datosNomina (string cedula)
        {
            using (SqlConnection conn = new SqlConnection (ConexionBase.cadenaConexion)) 
            {
                conn.Open ();
                try
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT H_E25, H_E50,H_E100,SUELDO_BASE FROM TRABAJADORES WHERE CEDULA = @CEDULA";
                        cmd.Parameters.AddWithValue ("@CEDULA", cedula);
                        SqlDataReader dr = cmd.ExecuteReader ();
                        if (dr.Read())
                        {
                            horaN = Convert.ToDecimal(dr.GetDouble (0));
                            he50 = Convert.ToDecimal(dr.GetDouble(1));
                            he100 = Convert.ToDecimal(dr.GetDouble(2));
                            sueldoXdia = Convert.ToDecimal(Math.Round(dr.GetDouble(3) / 30, 6)); 
                            dr.Close ();
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
            }
        }
    }
}

