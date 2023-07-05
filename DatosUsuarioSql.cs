using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public class DatosUsuarioSql
    {
        public bool logonUser(string user, string pass)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion))
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT * FROM USUARIOS where LoginName=@user and Password=@pass";
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue ("@pass", pass);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read())
                        {
                            CacheLogon.IdUser = reader.GetInt32(0);
                            CacheLogon.FirstName = reader.GetString(3);
                            CacheLogon.LastName = reader.GetString(4);
                            CacheLogon.Position = reader.GetString(5);
                            CacheLogon.Email = reader.GetString(6);
                            CacheLogon.LoginName = reader.GetString(1);
                        }
                        return true;
                    }else { return false; }
                }
            }

        }
    }
}
