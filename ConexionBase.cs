using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoRoles
{
    public class ConexionBase
    {
        //conexion a a la base de datos
        public static string cadenaConexion = "Data Source=SISTEMAS1\\SQLEXPRESS;Initial Catalog=ROLES; Integrated Security=True";
        //public SqlConnection conectarBD = new SqlConnection();

        //public ConexionBase()
        //{
          //  conectarBD.ConnectionString = cadenaConexion;
        //}
        //public void abrir()
        //{
          //  try
            //{
              //  conectarBD.Open();
                //MessageBox.Show("Conexion con la base de datos completada", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
              //  throw new Exception("Error al abrir la base de datos", ex);
            //}
        //}
    }

}
