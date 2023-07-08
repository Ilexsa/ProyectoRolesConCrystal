using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoRoles
{
    public class ConexionBase
    {
        //conexion a a la base de datos
        public static string cadenaConexion = "Data Source=10.0.0.206;Initial Catalog=ROLES;User ID=sa;Password=";
        //public static string cadenaConexion = "Data Source=DESKTOP-R8E20GK\\SQLEXPRESS01;Initial Catalog=ROLES;Integrated Security=True";
        //public SqlConnection conectarBD = new SqlConnection();

        //public ConexionBase()
        //{
        //    conectarBD.ConnectionString = cadenaConexion;
        //}
        //public void abrir()
        //{
        //    try
        //    {
        //        conectarBD.Open();
        //        MessageBox.Show("Conexion con la base de datos completada", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al abrir la base de datos", ex);
        //    }
        //}
    }

}
