using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public class EnviarCorreosAutomaticos
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);

        public void correosMasivos(string carpetaPdfs)
        {
            string host = "fundasen.com.ec";
            int port = 465;
            string correo = "jayala@fundasen.com.ec";
            string pass = "EN{]zMPkAOki";
            //configuracion del servidor smtp
            var smtp = new SmtpClient();
            smtp.CheckCertificateRevocation = false;
            smtp.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            smtp.Connect(host,port,SecureSocketOptions.SslOnConnect);
            smtp.Authenticate(correo,pass);
            //Obtener mes y año de la carpeta
            string[] partesCarpeta = Path.GetFileName(folderPath).Split('-');
        }

        private string GetCorreos(string cedula)
        {
            conexion.Open();
            string queryCorreo = "SELECT CORREO FROM TRABAJADORES WHERE CEDULA = @CEDULA";
            SqlCommand comando = new SqlCommand(queryCorreo,conexion);
            using (var reader = comando.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader ["CORREO"].ToString();
                }
            }
            return null;
        }
    }
}






  
