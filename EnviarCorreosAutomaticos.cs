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
using System.Data;
using System.Windows.Forms.VisualStyles;

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
            string[] partesCarpeta = Path.GetFileName(carpetaPdfs).Split('-');
            int mes = int.Parse(partesCarpeta[1]);
            int año = int.Parse(partesCarpeta[2]);

            string[] archivos = Directory.GetFiles(carpetaPdfs);

            foreach (string rutaArchivos in archivos)
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(rutaArchivos);
                string[] partesNombreA = nombreArchivo.Split('-');
                string cedula = partesNombreA[0];

                string email = GetCorreos(cedula);
                if (!string.IsNullOrEmpty(email))
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("FUNDASEN TTHH", correo));
                    message.To.Add(new MailboxAddress("Destinatario", email));
                    message.Subject = "Rol de pago perteneciente al:"+ mes +"/"+año;
                    BodyBuilder builder = new BodyBuilder();
                    //builder.TextBody = "Buenas tardes estimado, esta recibiendo el rol de pago correspondiente a su mes de trabajo. \n ¡Tenga un buen día!";
                    builder.HtmlBody = @"<html>
                                        <body>
                                            <p>Buenas tardes estimado, está recibiendo el rol de pago correspondiente a su mes de trabajo. ¡Tenga un buen día!</p>
                                            <img src=""cid:firma"" alt=""Firma"">
                                        </body>
                                    </html>";
                    var rutaFirma = "C:\\Users\\jayala\\Desktop\\JONATHAN-AYALA.jpg";
                    var firmaAttach = new MimePart("image", "jpg")
                    {
                        Content = new MimeContent(File.OpenRead(rutaFirma)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Inline),
                        ContentId = "firma"
                        };
                    var atachment = new MimePart("application" , "pdf")
                        {
                            Content = new MimeContent(File.OpenRead(rutaArchivos)),
                            ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                            ContentTransferEncoding = ContentEncoding.Base64,
                            FileName = Path.GetFileName(rutaArchivos)
                        };
                    builder.Attachments.Add( atachment );
                    builder.Attachments.Add( firmaAttach );
                    message.Body = builder.ToMessageBody();
                    smtp.Send( message );
                }
            }
        }

        private string GetCorreos(string cedula)
        {
            conexion.Close();
            conexion.Open();
            string queryCorreo = "SELECT CORREO FROM TRABAJADORES WHERE CEDULA = @CEDULA";
            SqlCommand comando = new SqlCommand(queryCorreo,conexion);
            comando.Parameters.AddWithValue("@CEDULA",cedula);
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