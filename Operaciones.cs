using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoRoles
{
    public class Operaciones
    {
        public bool SubirDatosTrabajadores(DataTable tbData)
        {
            bool resultado = true;
            using (SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion))
            {
                conexion.Open();
                using (SqlBulkCopy subirT = new SqlBulkCopy(conexion))
                {
                    //columExcel   columTable
                    subirT.ColumnMappings.Add("localidad", "IdLocalidad");
                    subirT.ColumnMappings.Add("Departamento", "IdDepartamento");
                    subirT.ColumnMappings.Add("Cedula", "CEDULA");                    
                    subirT.ColumnMappings.Add("Apellidos y Nombres", "NOMBRES");
                    subirT.ColumnMappings.Add("Fecha de Ingreso", "FECHA_INGRESO");
                    subirT.ColumnMappings.Add("Cargo", "CARGO");
                    subirT.ColumnMappings.Add("Correo", "CORREO");
                    subirT.ColumnMappings.Add("Sueldo Base", "SUELDO_BASE");
                    subirT.ColumnMappings.Add("Personal con discapacidad y grupo vulnerable", "PER_DISCAPACIDAD");
                    
                    //tabla a la que vamos a apuntar
                    subirT.DestinationTableName = "TRABAJADORES";

                    subirT.BulkCopyTimeout = 1500;
                    try
                    {
                        subirT.WriteToServer(tbData);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al subir los datos a la base, revisa excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = false;
                    }
                    
               }
            }
            return resultado;
        }
        public bool SubirNomina(DataTable tbData)
        {
            bool resultado = true;
            using (SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion))
            {
                conexion.Open();
                using (SqlBulkCopy subirN = new SqlBulkCopy(conexion))
                {
                    //columExcel   columTable
                    subirN.ColumnMappings.Add("cedula", "CEDULA");
                    subirN.ColumnMappings.Add("localidad", "MATER_ENFG");
                    subirN.ColumnMappings.Add("departamento", "ALIMENTACION");
                    subirN.ColumnMappings.Add("nombres", "MOVILIZACION");
                    subirN.ColumnMappings.Add("fecha de ingreso", "OTROS_INGRESOS_NA");
                    subirN.ColumnMappings.Add("cargo", "OTROS_INGRESOS_A");
                    subirN.ColumnMappings.Add("sueldo base", "R_NOCTURNO");
                    subirN.ColumnMappings.Add("personal con discapacidad", "R_NOCTURNO50");
                    subirN.ColumnMappings.Add("cedula", "R_NOCTURNO100");
                    subirN.ColumnMappings.Add("localidad", "EXTRAS");
                    subirN.ColumnMappings.Add("departamento", "INGRESOS_IESS");
                    subirN.ColumnMappings.Add("nombres", "T_INGRESOS");
                    subirN.ColumnMappings.Add("fecha de ingreso", "A_QUINCENA");
                    subirN.ColumnMappings.Add("cargo", "P_QUIROGRAFARIOS");
                    subirN.ColumnMappings.Add("sueldo base", "P_HIPOTECARIOS");
                    subirN.ColumnMappings.Add("personal con discapacidad", "DESCUENTO_PERMISOS_MEDICOS");
                    subirN.ColumnMappings.Add("cedula", "CxP");
                    subirN.ColumnMappings.Add("localidad", "DESCUADRES");
                    subirN.ColumnMappings.Add("departamento", "SUPA");
                    subirN.ColumnMappings.Add("nombres", "EGRESOS_IESS");
                    subirN.ColumnMappings.Add("departamento", "T_EGRESOS");
                    subirN.ColumnMappings.Add("nombres", "NETO_RECIBIR");

                    //tabla a la que vamos a apuntar
                    subirN.DestinationTableName = "NOMINA";

                    subirN.BulkCopyTimeout = 1500;
                    try
                    {
                        subirN.WriteToServer(tbData);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al subir los datos a la base, revisa el archivo excel por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = false;
                    }

                }
            }
            return resultado;
        }
    }
}
