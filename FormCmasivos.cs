using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using OpenPop;
using OpenPop.Pop3;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Security;
using System.IO;
using ProyectoRoles;

namespace ProyectoRolesConCrystal
{
    public partial class FormCmasivos : Form
    {
        public FormCmasivos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnvioCorreos();
        }
        private void EnvioCorreos()
        {
            try
            {
                string correoO = "jayala@fundasen.com.ec";
                string correoD = "soporte@fundasen.com.ec";
                string pass = "EN{]zMPkAOki";
                string servidor = "mail.fundasen.com.ec";
                int puerto = 465;
                MimeMessage mail = new MimeMessage();
                mail.From.Add(new MailboxAddress("Pruebas", correoO));
                mail.To.Add(new MailboxAddress("Destino", correoD));
                mail.Subject = "Pruebas correos c#";
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Prueba de correo";
                var atachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead("C:\\Users\\jayala\\Documents\\Roles\\0953398575Rol.pdf")),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName= "0953398575Rol.pdf"
                };
                bodyBuilder.Attachments.Add( atachment );
                mail.Body = bodyBuilder.ToMessageBody();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.CheckCertificateRevocation = false;
                smtpClient.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                smtpClient.Connect(servidor, puerto, MailKit.Security.SecureSocketOptions.SslOnConnect);
                smtpClient.Authenticate(correoO, pass);
                smtpClient.Send(mail);
                smtpClient.Disconnect(true);
                MessageBox.Show("correo enviado", "success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baseFolderPath = "C:\\Roles";
            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            string nombreCarpeta = $"Roles-{mes:00}-{año}";
            string carpetaPDFS = Path.Combine(baseFolderPath, nombreCarpeta);
            EnviarCorreosAutomaticos enviarCorreos = new EnviarCorreosAutomaticos();
            try
            {
                enviarCorreos.correosMasivos(carpetaPDFS);
                MessageBox.Show("Correos enviados con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FormCmasivos_Load(object sender, EventArgs e)
        {

        }
    }
}
