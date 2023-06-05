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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoRolesConCrystal
{
    public class GenerarReportes
    {
        SqlConnection conexion =new SqlConnection(ConexionBase.cadenaConexion);

        public void generarPDFS()
        {
            string direccionRpt = "C:\\Users\\jayala\\source\\repos\\ProyectoRolesConCrystal\\reporteRol.rpt";

            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            DataTable cedulasTable = GetCedula(ConexionBase.cadenaConexion);
            //creacion de directorio
            string nombreCarpeta = $"Roles-{mes:00}-{año}";
            string creacionR = Path.Combine("C:\\Roles", nombreCarpeta);
            Directory.CreateDirectory(creacionR);
            //ciclo que generara los pdfs individuales 
            foreach(DataRow row in cedulasTable.Rows)
            {
                string cedula = row["CEDULA"].ToString();
                //valores de los parametros del reporte
                ReportDocument reporteRol = new ReportDocument();
                reporteRol.Load(direccionRpt);
                reporteRol.SetParameterValue("@CEDULA", cedula);
                reporteRol.SetParameterValue("@MES_ROL", mes);
                reporteRol.SetParameterValue("@AÑO_ROL", año);
                //PDF NOMBRES Y DEMAS
                string pdfNombre = $"{cedula}-{mes:00}-{año}.pdf";
                string pdfUbicacion = Path.Combine(creacionR, pdfNombre);
                reporteRol.ExportToDisk(ExportFormatType.PortableDocFormat, pdfUbicacion);

                reporteRol.Close();
                reporteRol.Dispose();
            }
        }
        private DataTable GetCedula(string cadenaC)
        {
            DataTable cedulasTable = new DataTable();
            conexion.Open();
            string queryCedulas = "SELECT CEDULA FROM NOMINA";
            SqlCommand cmd = new SqlCommand(queryCedulas, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(cedulasTable);
            conexion.Close();
            return cedulasTable;
        }
    }
}
