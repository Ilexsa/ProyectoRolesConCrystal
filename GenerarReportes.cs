using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Data.SqlClient;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public class GenerarReportes
    {
        SqlConnection conexion =new SqlConnection(ConexionBase.cadenaConexion);
        public void generarPDFS()
        {

        }
    }
}
