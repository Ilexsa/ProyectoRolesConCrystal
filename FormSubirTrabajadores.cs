using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoRoles;
using System.Transactions;
using Microsoft.Identity.Client;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Media;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using PdfiumViewer;


namespace ProyectoRolesConCrystal
{
    public partial class FormSubirTrabajadores : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        //Configuraciones del Gmap
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        double Latinicial = -2.138212840521418;
        double Lnginicial = -79.899110000004884;
        byte[] imagen = null;
        string rutaDelPDF;
        public string cedulaTrabajadorCarga { get; set; }
        public FormSubirTrabajadores()
        {
            InitializeComponent();
        }

        private void btnPrimerRegistro_Click(object sender, EventArgs e)
        {
            LastTrabajador();
            leerTrabajador(txtCedula.Text);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            previousTrabajador();
            leerTrabajador(txtCedula.Text);
        }

        private void btnUltimoRegistro_Click(object sender, EventArgs e)
        {
            firstTrabajador();
            leerTrabajador(txtCedula.Text);
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            habilitarEdicion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextTrabajador();
            leerTrabajador(txtCedula.Text);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ObtenerPDF();
            //MostrarVistaPreviaPDF(rutaDelPDF);
        }

        private void btnBuscarSectorial_Click(object sender, EventArgs e)
        {
            frmBusquedaSectoriales frmBusquedaSectoriales = new frmBusquedaSectoriales();
            frmBusquedaSectoriales.ShowDialog();
            txtIDSectorial.Text = frmBusquedaSectoriales.ID;
            txtCodigoIESS.Text = frmBusquedaSectoriales.Sectorial;
            txtCargo.Text = frmBusquedaSectoriales.cargo;
            txtSueldo.Text = frmBusquedaSectoriales.sueldo;
        }

        private void txtGmap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkEnlace.Checked == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    obtenerCoordenadasxEnlace(txtGmap.Text);
                }
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    obtenerCoordenadas(txtGmap.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusquedaSR frmBusquedaSR = new frmBusquedaSR();
            frmBusquedaSR.ShowDialog();
            string cedulaSeleccionada = frmBusquedaSR.cedulaSeleccionada;
            leerTrabajador(frmBusquedaSR.cedulaSeleccionada);
            txtCedula.Text = frmBusquedaSR.cedulaSeleccionada;
        }


        private void btnAgg_Click(object sender, EventArgs e)
        {
            //conexion.Open();
            //try
            //{
            //    double sueldo = Convert.ToDouble(txtSueldo.Text);
            //    double pagoHora = (sueldo / 30) / 8;
            //    double H_E25 = Math.Round((pagoHora / 4) + pagoHora, 2);
            //    double H_E50 = Math.Round((pagoHora / 2) + pagoHora, 2);
            //    double H_E100 = Math.Round((pagoHora) * 2, 2);
            //    string add = "insert into TRABAJADORES values (@CEDULA, @IdLocalidad, @IdDepartamento, @NOMBRES, @FECHA_INGRESO, @CARGO, @SUELDO_BASE, @PER_DISCAPACIDAD, @CORREO ,@H_E25, @H_E50, @H_E100, DEFAULT, @FECHA_INACTIVO, @FECHA_REINGRESO,  @DT)";
            //    SqlCommand comando = new SqlCommand(add, conexion);
            //    comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            //    comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
            //    comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
            //    comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text.ToUpper());
            //    comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
            //    comando.Parameters.AddWithValue("@CARGO", txtCargo.Text.ToUpper());
            //    comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
            //    //comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
            //    comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
            //    comando.Parameters.AddWithValue("@H_E25", H_E25);
            //    comando.Parameters.AddWithValue("@H_E50", H_E50);
            //    comando.Parameters.AddWithValue("@H_E100", H_E100);
            //    //comando.Parameters.AddWithValue("@ESTADO", DB);
            //    comando.Parameters.AddWithValue("@FECHA_INACTIVO", DBNull.Value);
            //    comando.Parameters.AddWithValue("@FECHA_REINGRESO", DBNull.Value);
            //    comando.ExecuteNonQuery();
            //    MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    recargarTabla();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //conexion.Close();
            if (txtCedula.Enabled == true) {
                aggTrabajador();
                invocarCargas();
            }
            else{
                MessageBox.Show("La edicion/creacion no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSubirTrabajadores_Load(object sender, EventArgs e)
        {
            ptbFoto.AllowDrop = true;
            ptbFoto.DragEnter += ptbImagen_DragEnter;
            ptbFoto.DragDrop += ptbImagen_DragDrop;
            ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            List<KeyValuePair<string, string>> discapacidades = new List<KeyValuePair<string, string>>{
                new KeyValuePair<string, string>("1. Fisica" , "Fisica"),
                new KeyValuePair<string, string>("2. Intelectual" , "Intelectual"),
                new KeyValuePair<string, string>("3. Mental" , "Mental"),
                new KeyValuePair<string, string>("4. Psicosocial" , "Psicosocial"),
                new KeyValuePair<string, string>("5. Multiple" , "Multiple"),
                new KeyValuePair<string, string>("6. Sensorial" , "Sensorial"),
                new KeyValuePair<string, string>("7. Auditiva" , "Auditiva"),
                new KeyValuePair<string, string>("8. Visual" , "Visual")
            };
            cmbDiscapacidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscapacidad.DataSource = discapacidades;
            cmbDiscapacidad.ValueMember = "Value";
            cmbDiscapacidad.DisplayMember = "Key";
            string cedula = txtCedula.Text;
            // generamos un string que tiene los valores del select par la base 
            string consultaBase = "select * from TRABAJADORES";
            // vamos a generar un adaptador para que adapte la tablas y columnas de la base,usa como parametros la consulta
            //y la conexion para ver en que base se tiene que conectar
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaBase, conexion);
            // se debe guardar todo en una tabla virtual, todos los datos que el select ha traido de la tabla 
            DataTable dtTRABAJADORES = new DataTable();
            //Utilizando el adaptador antes declarado, lo vamos a llenar con los datos de la tabla virtual llamada tbNomina
            adaptador.Fill(dtTRABAJADORES);
            //y ahora le vamos a dar el origen de los datos a dgv.
            //rellenar combo_box Localidad
            DataTable dtLocalidades = new DataTable();
            string llenarcmbL = "select ID,LOCALIDAD from LOCALIDADES";
            SqlDataAdapter adaptadorLoc = new SqlDataAdapter(llenarcmbL, conexion);
            adaptadorLoc.Fill(dtLocalidades);
            cmbLocalidad.DataSource = dtLocalidades;
            cmbLocalidad.DisplayMember = "LOCALIDAD";
            cmbLocalidad.ValueMember = "ID";
            //rellenar combo_box Departamento
            DataTable dtDepartamentos = new DataTable();
            string llenarcmbD = "select ID,DEPARTAMENTO from DEPARTAMENTOS";
            SqlDataAdapter adptadorDep = new SqlDataAdapter(llenarcmbD, conexion);
            adptadorDep.Fill(dtDepartamentos);
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DataSource = dtDepartamentos;
            cmbDepartamento.DisplayMember = "DEPARTAMENTO";
            cmbDepartamento.ValueMember = "ID";
            //rellenar cmb_contratos
            DataTable dtContratos = new DataTable();
            string llenarcmbC = "SELECT ID_TIPO_CONTRATO,TIPO_CONTRATO FROM TIPOS_CONTRATO";
            SqlDataAdapter adaptadorContratos = new SqlDataAdapter(llenarcmbC, conexion);
            adaptadorContratos.Fill(dtContratos);
            cmbContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContrato.DataSource = dtContratos;
            cmbContrato.DisplayMember = "TIPO_CONTRATO";
            cmbContrato.ValueMember = "ID_TIPO_CONTRATO";
            //CAMBIAR FORMATO DATETIMEPICKER
            //dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaI.CustomFormat = "dd-MM-yyyy";
            dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
            gmapConfigs();
            firstTrabajador();
            leerTrabajador(txtCedula.Text);
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            //conexion.Open();
            //try
            //{
            //    double sueldo = Convert.ToDouble(txtSueldo.Text);
            //    double pagoHora = (sueldo / 30) / 8;
            //    double H_E25 = Math.Round((pagoHora / 4) + pagoHora, 2);
            //    double H_E50 = Math.Round((pagoHora / 2) + pagoHora, 2);
            //    double H_E100 = Math.Round((pagoHora) * 2, 2);
            //    int flag = 0;
            //    string mod = "update TRABAJADORES set Idlocalidad=@Idlocalidad, IdDepartamento=@IdDepartamento, NOMBRES=@NOMBRES," +
            //    "FECHA_INGRESO=@FECHA_INGRESO, CARGO=@CARGO, SUELDO_BASE=@SUELDO_BASE, PER_DISCAPACIDAD=@PER_DISCAPACIDAD, CORREO=@CORREO " +
            //    ", H_E25=@H_E25, H_E50=@H_E50, H_E100=@H_E100 where CEDULA=@CEDULA";
            //    SqlCommand comando = new SqlCommand(mod, conexion);
            //    comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            //    comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
            //    comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
            //    comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text);
            //    comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
            //    comando.Parameters.AddWithValue("@CARGO", txtCargo.Text);
            //    comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
            //    //comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
            //    comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
            //    comando.Parameters.AddWithValue("@H_E25", H_E25);
            //    comando.Parameters.AddWithValue("@H_E50", H_E50);
            //    comando.Parameters.AddWithValue("@H_E100", H_E100);
            //    //comando.Parameters.AddWithValue("@FECHA_INACTIVO", DBNull.Value);
            //    //comando.Parameters.AddWithValue("@FECHA_REINGRESO", DBNull.Value);

            //    flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko
            //    // Buscamos la fila que deseamos actualizar
            if(txtCedula.Enabled == true){
                editarTrabajador();
            }
            else
            {
                MessageBox.Show("La edicion/creacion no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtCedula.Text == "")
            {
                MessageBox.Show("No se puede eliminar un registro sin el numero de cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCedula.Text != "")
            {
                try
                {
                    int flag = 0;
                    string cedula = txtCedula.Text;
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        string consultaBorrar = "DELETE FROM TRABAJADORES WHERE CEDULA=@CEDULA";
                        SqlCommand comando = new SqlCommand(consultaBorrar, conexion);
                        comando.Parameters.AddWithValue("@CEDULA", cedula);
                        flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko
                    }

                    if (flag == 1)
                    {
                        MessageBox.Show("Registro eliminado con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (flag == 0)
                    {
                        //MessageBox.Show("No se pudo borrar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCanmpos();
        }

        private void chkDiscapacidad_CheckedChanged(object sender, EventArgs e)
        {
            txtPorcentajeD.Enabled = chkDiscapacidad.Checked;
            label10.Enabled = chkDiscapacidad.Checked;
            label11.Enabled = chkDiscapacidad.Checked;
            cmbDiscapacidad.Enabled = chkDiscapacidad.Checked;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void LimpiarDatos()
        {
            txtCargo.Clear();
            //txtDiscapacidad.Clear();
            txtNombre.Clear();
            txtCargo.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            //txtDiscapacidad.Clear();
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de inactivar al trabajador?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    string inactivar = "UPDATE TRABAJADORES SET ESTADO=0, FECHA_INACTIVO= GETDATE() WHERE CEDULA =@CEDULA";
                    SqlCommand comando = new SqlCommand(inactivar, conexion);
                    comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de reactivar al trabajador?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    string reingreso = "UPDATE TRABAJADORES SET ESTADO=1, FECHA_REINGRESO= GETDATE() WHERE CEDULA =@CEDULA";
                    SqlCommand comando = new SqlCommand(reingreso, conexion);
                    comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }
        public void btnInforme_Click(object sender, EventArgs e)
        {
            frmReporteColaboradores reporteColaboradores = new frmReporteColaboradores();
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\jayala\\source\\repos\\ProyectoRolesConCrystal\\ReporteColaboradores.rpt");
            report.SetParameterValue("@ID_DEPARTAMENTO", cmbDepartamento.SelectedValue);
            reporteColaboradores.crystalReportViewer1.ReportSource = report;
            reporteColaboradores.Show();
            //crystalReportViewer1.ReportSource = report;
        }
        public void fInforme()
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarCedula validarCedula = new ValidarCedula();
                bool verificarCedula = validarCedula.P_Valida_Cedula(txtCedula.Text);
                if (chkPasaporte.Checked == false)
                {
                    if (verificarCedula == true)
                    {
                        MessageBox.Show("Numero de cedula valido", "Cedula valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (verificarCedula == false)
                {
                    MessageBox.Show("Numero de cedula no valido", "Cedula no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedula.Clear();
                }
            }
        }

        private void txtPorcentajeD_Leave(object sender, EventArgs e)
        {
            int porcentajeIngresado = Convert.ToInt32(txtPorcentajeD.Text);
            if (porcentajeIngresado < 30)
            {
                MessageBox.Show("No cumple con el % minimo de discapacidad", "No califica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkDiscapacidad.Checked = false;
                cmbDiscapacidad.SelectedIndex = 0;
                txtPorcentajeD.Text = "";
            }
        }

        //private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        //{
        //    if (dtpFechaNacimiento.Value == DateTime.Now) 
        //    {

        //    }
        //    else
        //    {
        //        DateTime nacimiento = dtpFechaNacimiento.Value; //Fecha de nacimiento
        //        int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
        //        txtEdad.Text = edad.ToString();
        //    }
        //}

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            ValidarCedula validarCedula = new ValidarCedula();
            bool verificarCedula = validarCedula.P_Valida_Cedula(txtCedula.Text);
            if (chkPasaporte.Checked == false)
            {
            }
        }

        private void gmapConfigs()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latinicial, Lnginicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;


            // Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Latinicial, Lnginicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            // Agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \n Longitud:{1}", Latinicial, Lnginicial);

            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud:{1}", lat, lng);
            txtLat.Text = lat.ToString();
            txtLng.Text = lng.ToString();
        }

        private void obtenerCoordenadas(string enlace)
        {
            string[] coordenadas = txtGmap.Text.Split(',');
            if (coordenadas.Length == 2)
            {
                txtLat.Text = coordenadas[0];
                txtLng.Text = coordenadas[1];
                PointLatLng location = new PointLatLng(Convert.ToDouble(coordenadas[0]), Convert.ToDouble(coordenadas[1]));
                gMapControl1.Position = location;
                double lat = Convert.ToDouble(coordenadas[0]);
                double lng = Convert.ToDouble(coordenadas[1]);
                marker.Position = new PointLatLng(lat, lng);
                marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud:{1}", lat, lng);
            }

        }
        private void obtenerCoordenadasxEnlace(string enlace)
        {
            //Buscar el patrón de las coordenadas
            string patron = @"@([-]?[\d.]+),([-]?[\d.]+)";

            //Utilizar una expresión regular para encontrar las coordenadas en el enlace
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(enlace, patron);

            if (match.Success && match.Groups.Count == 3)
            {
                // Obtener la latitud y longitud
                txtLat.Text = match.Groups[1].Value;
                txtLng.Text = match.Groups[2].Value;
                PointLatLng location = new PointLatLng(Convert.ToDouble(match.Groups[1].Value), Convert.ToDouble(match.Groups[2].Value));
                gMapControl1.Position = location;
                double lat = Convert.ToDouble(match.Groups[1].Value);
                double lng = Convert.ToDouble(match.Groups[2].Value);
                marker.Position = new PointLatLng(lat, lng);
                marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud:{1}", lat, lng);
            }
            else
            {
                MessageBox.Show("Coordenas no encontradas", "Error");
            }
        }
        private void ptbImagen_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Obtener la ruta del archivo arrastrado
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string imagePath = files[0]; // Tomamos solo el primer archivo arrastrado

                // Leer los datos de la imagen en un arreglo de bytes
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    imagen = new byte[fs.Length];
                    fs.Read(imagen, 0, Convert.ToInt32(fs.Length));
                }

                // Mostrar la imagen en el PictureBox
                using (MemoryStream ms = new MemoryStream(imagen))
                {
                    ptbFoto.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }

        private void ptbImagen_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ptbImagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (ptbFoto.Image != null)
            {
                // Iniciar la operación de arrastre de imagen
                ptbFoto.DoDragDrop(ptbFoto.Image, DragDropEffects.Copy);
            }
        }

        private void ptbImagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ptbFoto.Image != null)
            {
                // Iniciar la operación de arrastre de imagen
                ptbFoto.DoDragDrop(ptbFoto.Image, DragDropEffects.Copy);
            }
        }

        private void aggTrabajador()
        {
            try
            {
                conexion.Open();
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                double pagoHora = (sueldo / 30) / 8;
                double H_E25 = Math.Round((pagoHora / 4) + pagoHora, 2);
                double H_E50 = Math.Round((pagoHora / 2) + pagoHora, 2);
                double H_E100 = Math.Round((pagoHora) * 2, 2);
                byte[] archivoPDF = File.ReadAllBytes(rutaDelPDF);
                SqlCommand sqlCommand = new SqlCommand("sp_SubirTrabajadores", conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CEDULA", txtCedula.Text); // Ingresa el valor de la cédula
                sqlCommand.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue); // Ingresa el valor del IdLocalidad
                sqlCommand.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue); // Ingresa el valor del IdDepartamento
                sqlCommand.Parameters.AddWithValue("@NOMBRES", txtNombre.Text); // Ingresa el valor de los nombres
                sqlCommand.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value); // Ingresa la fecha de ingreso
                sqlCommand.Parameters.AddWithValue("@CARGO", txtCargo.Text); // Ingresa el valor del cargo
                sqlCommand.Parameters.AddWithValue("@SUELDO_BASE", Convert.ToDouble(txtSueldo.Text)); // Ingresa el valor del sueldo base
                sqlCommand.Parameters.AddWithValue("@NACIONALIDAD", txtNacionalidad.Text);
                if (chkDiscapacidad.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@PER_DISCAPACIDAD", 1); // Ingresa el valor de PER_DISCAPACIDAD (true/false)
                    sqlCommand.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", Convert.ToInt32(txtPorcentajeD.Text)); // Ingresa el valor de PORCENTAJE_DISCAPACIDAD
                    sqlCommand.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", cmbDiscapacidad.SelectedValue); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@PER_DISCAPACIDAD", 0);
                    sqlCommand.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", DBNull.Value); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                sqlCommand.Parameters.AddWithValue("@CORREO", txtCorreo.Text); // Ingresa el valor del correo
                sqlCommand.Parameters.AddWithValue("@H_E25", H_E25); // Ingresa el valor de H_E25
                sqlCommand.Parameters.AddWithValue("@H_E50", H_E50); // Ingresa el valor de H_E50
                sqlCommand.Parameters.AddWithValue("@H_E100", H_E100); // Ingresa el valor de H_E100
                sqlCommand.Parameters.AddWithValue("@FECHA_INACTIVO", DBNull.Value); // Ingresa la fecha de inactivo (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@FECHA_REINGRESO", DBNull.Value); // Ingresa la fecha de reingreso (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@DT", DBNull.Value); // Ingresa el valor de DT
                sqlCommand.Parameters.AddWithValue("@FECHA_NACIMIENTO", dtpFechaNacimiento.Value); // Ingresa la fecha de nacimiento
                sqlCommand.Parameters.AddWithValue("@NUM_CELULAT", txtCelular.Text); // Ingresa el número de celular
                sqlCommand.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text); // Ingresa la dirección
                sqlCommand.Parameters.AddWithValue("@REFERENCIA_DIRECCION", txtReferencias.Text); // Ingresa la referencia de dirección
                sqlCommand.Parameters.AddWithValue("@LATITUD_D", txtLat.Text); // Ingresa la latitud
                sqlCommand.Parameters.AddWithValue("@LONGITUD_D", txtLng.Text); // Ingresa la longitud
                sqlCommand.Parameters.AddWithValue("@TELEFONO_CONVENCIONAL", txtConvencional.Text); // Ingresa el número de teléfono convencional
                sqlCommand.Parameters.AddWithValue("@TELEFONO_CELULAR", txtCelular.Text); // Ingresa el número de teléfono celular
                sqlCommand.Parameters.AddWithValue("@CORREO2", txtCorreo2.Text); // Ingresa el segundo correo
                if (rdbCasado.Checked == true) {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "CASADO"); // Ingresa el estado civil
                } else if (rdbSoltero.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "SOLTERO"); // Ingresa el estado civil
                } else if (rdbUnionH.Checked == true) {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "UNION DE HECHOS");
                }
                sqlCommand.Parameters.AddWithValue("@TIPO_RELACION_LABORAL", DBNull.Value); // Ingresa el tipo de relación laboral
                sqlCommand.Parameters.AddWithValue("@NOVEDAD_INGRESO", DBNull.Value); // Ingresa la novedad de ingreso
                sqlCommand.Parameters.AddWithValue("@PDF_INGRESO", archivoPDF); // Ingresa el PDF de ingreso (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@ID_CONTRATO", cmbContrato.SelectedValue); // Ingresa el valor de ID_CONTRATO
                sqlCommand.Parameters.AddWithValue("@ID_SECTORIAL", Convert.ToInt32(txtIDSectorial.Text)); // Ingresa el valor de ID_SECTORIAL
                sqlCommand.Parameters.AddWithValue("@ID_CARGAS", DBNull.Value); // Ingresa el valor de ID_CARGAS
                sqlCommand.Parameters.AddWithValue("@FOTO", imagen); // Ingresa la foto (si no aplica, deja DBNull.Value)
                MessageBox.Show("Trabajador registrado con exito", "Success");
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cedulaTrabajadorCarga = txtCedula.Text;
                rutaDelPDF = "";

                conexion.Close();
            }
        }
        private void editarTrabajador()
        {
            try
            {
                conexion.Open();
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                double pagoHora = (sueldo / 30) / 8;
                double H_E25 = Math.Round((pagoHora / 4) + pagoHora, 2);
                double H_E50 = Math.Round((pagoHora / 2) + pagoHora, 2);
                double H_E100 = Math.Round((pagoHora) * 2, 2);
                byte[] archivoPDF = File.ReadAllBytes(rutaDelPDF);
                SqlCommand sqlCommand = new SqlCommand("sp_EditarTrabajador", conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CEDULA", txtCedula.Text); // Ingresa el valor de la cédula
                sqlCommand.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue); // Ingresa el valor del IdLocalidad
                sqlCommand.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue); // Ingresa el valor del IdDepartamento
                sqlCommand.Parameters.AddWithValue("@NOMBRES", txtNombre.Text); // Ingresa el valor de los nombres
                sqlCommand.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value); // Ingresa la fecha de ingreso
                sqlCommand.Parameters.AddWithValue("@CARGO", txtCargo.Text); // Ingresa el valor del cargo
                sqlCommand.Parameters.AddWithValue("@SUELDO_BASE", Convert.ToDouble(txtSueldo.Text)); // Ingresa el valor del sueldo base
                if (chkDiscapacidad.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@PER_DISCAPACIDAD", 1); // Ingresa el valor de PER_DISCAPACIDAD (true/false)
                    sqlCommand.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", Convert.ToInt32(txtPorcentajeD.Text)); // Ingresa el valor de PORCENTAJE_DISCAPACIDAD
                    sqlCommand.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", cmbDiscapacidad.SelectedValue); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@PER_DISCAPACIDAD", 0);
                    sqlCommand.Parameters.AddWithValue("@PORCENTAJE_DISCAPACIDAD", DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", DBNull.Value); // Ingresa el valor de TIPO_DISCAPACIDAD
                }
                sqlCommand.Parameters.AddWithValue("@CORREO", txtCorreo.Text); // Ingresa el valor del correo
                sqlCommand.Parameters.AddWithValue("@H_E25", H_E25); // Ingresa el valor de H_E25
                sqlCommand.Parameters.AddWithValue("@H_E50", H_E50); // Ingresa el valor de H_E50
                sqlCommand.Parameters.AddWithValue("@H_E100", H_E100); // Ingresa el valor de H_E100
                sqlCommand.Parameters.AddWithValue("@FECHA_INACTIVO", DBNull.Value); // Ingresa la fecha de inactivo (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@FECHA_REINGRESO", DBNull.Value); // Ingresa la fecha de reingreso (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@DT", DBNull.Value); // Ingresa el valor de DT
                sqlCommand.Parameters.AddWithValue("@FECHA_NACIMIENTO", dtpFechaNacimiento.Value); // Ingresa la fecha de nacimiento
                sqlCommand.Parameters.AddWithValue("@NUM_CELULAT", txtCelular.Text); // Ingresa el número de celular
                sqlCommand.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text); // Ingresa la dirección
                sqlCommand.Parameters.AddWithValue("@REFERENCIA_DIRECCION", txtReferencias.Text); // Ingresa la referencia de dirección
                sqlCommand.Parameters.AddWithValue("@LATITUD_D", txtLat.Text); // Ingresa la latitud
                sqlCommand.Parameters.AddWithValue("@LONGITUD_D", txtLng.Text); // Ingresa la longitud
                sqlCommand.Parameters.AddWithValue("@TELEFONO_CONVENCIONAL", txtConvencional.Text); // Ingresa el número de teléfono convencional
                sqlCommand.Parameters.AddWithValue("@TELEFONO_CELULAR", txtCelular.Text); // Ingresa el número de teléfono celular
                sqlCommand.Parameters.AddWithValue("@CORREO2", txtCorreo2.Text); // Ingresa el segundo correo
                sqlCommand.Parameters.AddWithValue("@NACIONALIDAD", txtNacionalidad.Text);
                if (rdbCasado.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "CASADO"); // Ingresa el estado civil
                }
                else if (rdbSoltero.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "SOLTERO"); // Ingresa el estado civil
                }
                else if (rdbUnionH.Checked == true)
                {
                    sqlCommand.Parameters.AddWithValue("@ESTADO_CIVIL", "UNION DE HECHOS");
                }
                sqlCommand.Parameters.AddWithValue("@TIPO_RELACION_LABORAL", DBNull.Value); // Ingresa el tipo de relación laboral
                sqlCommand.Parameters.AddWithValue("@NOVEDAD_INGRESO", DBNull.Value); // Ingresa la novedad de ingreso
                sqlCommand.Parameters.AddWithValue("@PDF_INGRESO", archivoPDF); // Ingresa el PDF de ingreso (si no aplica, deja DBNull.Value)
                sqlCommand.Parameters.AddWithValue("@ID_CONTRATO", cmbContrato.SelectedValue); // Ingresa el valor de ID_CONTRATO
                sqlCommand.Parameters.AddWithValue("@ID_SECTORIAL", Convert.ToInt32(txtIDSectorial.Text)); // Ingresa el valor de ID_SECTORIAL
                sqlCommand.Parameters.AddWithValue("@ID_CARGAS", DBNull.Value); // Ingresa el valor de ID_CARGAS
                sqlCommand.Parameters.AddWithValue("@FOTO", imagen); // Ingresa la foto (si no aplica, deja DBNull.Value)
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Trabajador modificado con exito", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void habilitarEdicion()
        {
            if (txtCedula.Enabled == false)
            {
                txtCedula.Enabled = true;
                txtNombre.Enabled = true;
                chkEnlace.Enabled = true;
                txtGmap.Enabled = true;
                btnInactivar.Enabled = true;
                btnReactivar.Enabled = true;
                txtNacionalidad.Enabled = true;
                txtConvencional.Enabled = true;
                cmbContrato.Enabled = true;
                txtCodigoIESS.Enabled = true;
                txtCelular.Enabled = true;
                txtCorreo.Enabled = true;
                txtCorreo2.Enabled = true;
                txtEdad.Enabled = true;
                txtSueldo.Enabled = true;
                rdbCasado.Enabled = true;
                rdbSoltero.Enabled = true;
                rdbUnionH.Enabled = true;
                txtCargo.Enabled = true;
                txtReferencias.Enabled = true;
                txtDireccion.Enabled = true;
                cmbLocalidad.Enabled = true;
                cmbDepartamento.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                dtpFechaI.Enabled = true;
                chkPasaporte.Enabled = true;
                chkDiscapacidad.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                label12.Enabled = true;
                label13.Enabled = true;
                label14.Enabled = true;
                label15.Enabled = true;
                label15.Enabled = true;
                label16.Enabled = true;
                label18.Enabled = true;
                label19.Enabled = true;
                label20.Enabled = true;
                label17.Enabled = true;
                label21.Enabled = true;
                label22.Enabled = true;
                label23.Enabled = true;
                label24.Enabled = true;
                label25.Enabled = true;
                gMapControl1.Enabled = true;
                ptbFoto.Enabled = true;
                btnBuscarSectorial.Enabled = true;
                label23.Enabled = true;
                btnPDF.Enabled = true;
            }
            else
            {
                txtCedula.Enabled = false;
                txtNombre.Enabled = false;
                chkEnlace.Enabled = false;
                txtGmap.Enabled = false;
                btnInactivar.Enabled = false;
                btnReactivar.Enabled = false;
                txtNacionalidad.Enabled = false;
                txtConvencional.Enabled = false;
                cmbContrato.Enabled = false;
                txtCodigoIESS.Enabled = false;
                txtCelular.Enabled = false;
                txtCorreo.Enabled = false;
                txtCorreo2.Enabled = false;
                txtEdad.Enabled = false;
                txtSueldo.Enabled = false;
                txtDireccion.Enabled = false;
                txtReferencias.Enabled = false;
                rdbCasado.Enabled = false;
                rdbSoltero.Enabled = false;
                rdbUnionH.Enabled = false;
                txtCargo.Enabled = false;
                cmbLocalidad.Enabled = false;
                cmbDepartamento.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                dtpFechaI.Enabled = false;
                chkPasaporte.Enabled = false;
                chkDiscapacidad.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label17.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                gMapControl1.Enabled = false;
                ptbFoto.Enabled = false;
                btnBuscarSectorial.Enabled = false;
                btnPDF.Enabled = false;
            }
        }
        private void ObtenerPDF()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Seleccionar PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaPDF = openFileDialog.FileName;
                    rutaDelPDF = rutaPDF;
                }
                MessageBox.Show("El PDF esta listo para ser subido a la base de datos", "Success");
            }
            catch {
                MessageBox.Show("Archivo PDF no complatible", "Error");
            }
        }
        private void leerTrabajador(string cedula)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_leerTrabajadorxCedula", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA", cedula); // Pasa el valor de la cédula al parámetro del stored procedure
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txtCedula.Text = sqlDataReader["CEDULA"].ToString();
                    if ((sqlDataReader["CEDULA"].ToString()).Length > 10)
                    {
                        chkPasaporte.Checked = true;
                    }
                    else
                    {
                        chkPasaporte.Checked = false;
                    }
                    txtNombre.Text = sqlDataReader["NOMBRES"].ToString();
                    txtPorcentajeD.Text = sqlDataReader["PORCENTAJE_DISCAPACIDAD"].ToString();
                    if (Convert.ToInt32(sqlDataReader["PER_DISCAPACIDAD"]) == 1)
                    {
                        chkDiscapacidad.Checked = true;
                    }
                    else
                    {
                        chkDiscapacidad.Checked = false;
                    }
                    // Completa los demás campos TextBox, ComboBox y CheckBox aquí
                    dtpFechaNacimiento.Value = Convert.ToDateTime(sqlDataReader["FECHA_NACIMIENTO"]);
                    txtNacionalidad.Text = sqlDataReader["NACIONALIDAD"].ToString();
                    txtCelular.Text = sqlDataReader["NUM_CELULAT"].ToString();
                    txtConvencional.Text = sqlDataReader["TELEFONO_CONVENCIONAL"].ToString();
                    txtCorreo.Text = sqlDataReader["CORREO"].ToString();
                    txtCorreo2.Text = sqlDataReader["CORREO2"].ToString();
                    txtDireccion.Text = sqlDataReader["DIRECCION"].ToString();
                    txtReferencias.Text = sqlDataReader["REFERENCIA_DIRECCION"].ToString();
                    txtLng.Text = sqlDataReader["LONGITUD_D"].ToString();
                    txtLat.Text = sqlDataReader["LATITUD_D"].ToString();
                    PointLatLng location = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
                    gMapControl1.Position = location;
                    double lat = Convert.ToDouble(txtLat.Text);
                    double lng = Convert.ToDouble(txtLng.Text);
                    marker.Position = new PointLatLng(lat, lng);
                    marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud:{1}", lat, lng);
                    // Completa los demás campos TextBox aquí
                    if (sqlDataReader["ESTADO_CIVIL"].ToString() == "SOLTERO")
                    {
                        rdbSoltero.Checked = true;
                    }
                    else if (sqlDataReader["ESTADO_CIVIL"].ToString() == "CASADO")
                    {
                        rdbCasado.Checked = true;
                    }
                    else if (sqlDataReader["ESTADO_CIVIL"].ToString() == "UNION DE HECHOS")
                    {
                        rdbUnionH.Checked = true;
                    }
                    // Completa los ComboBox
                    cmbContrato.SelectedValue = Convert.ToInt32(sqlDataReader["ID_CONTRATO"]);
                    txtCodigoIESS.Text = sqlDataReader["CODIGO_IESS"].ToString();
                    txtIDSectorial.Text = sqlDataReader["ID_SECTORIAL"].ToString();
                    // Completa los demás ComboBox aquí

                    // Completa los CheckBox
                    bool perDiscapacidad = Convert.ToBoolean(sqlDataReader["PER_DISCAPACIDAD"]);
                    if (perDiscapacidad == true)
                    {
                        // Completa el campo relacionado a la discapacidad
                        chkDiscapacidad.Checked = true;
                        txtPorcentajeD.Text = sqlDataReader["PORCENTAJE_DISCAPACIDAD"].ToString();
                        cmbDiscapacidad.SelectedValue = Convert.ToInt32(sqlDataReader["TIPO_DISCAPACIDAD"]);
                    }
                    else
                    {
                        chkDiscapacidad.Checked = false;
                        txtPorcentajeD.Text = "";
                        cmbDiscapacidad.SelectedIndex = -1;
                    }
                    txtCargo.Text = sqlDataReader["CARGO"].ToString();
                    cmbLocalidad.SelectedValue = Convert.ToInt32(sqlDataReader["IdLocalidad"].ToString());
                    cmbDepartamento.SelectedValue = sqlDataReader["IdDepartamento"].ToString();
                    dtpFechaI.Value = Convert.ToDateTime(sqlDataReader["FECHA_INGRESO"].ToString());
                    txtSueldo.Text = sqlDataReader["SUELDO_BASE"].ToString();
                    txtIDSectorial.Text = sqlDataReader["ID_SECTORIAL"].ToString();
                    byte[] Foto = (byte[])sqlDataReader["FOTO"];
                    byte[] imagen = (byte[])sqlDataReader["FOTO"];
                    using (MemoryStream ms = new MemoryStream(Foto))
                    {
                        ptbFoto.Image = System.Drawing.Image.FromStream(ms);
                        ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    sqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conexion.Close();
            }
        }
        private void invocarCargas()
        {
            frmCargas frmCargas = new frmCargas();
            if (rdbCasado.Checked == true || rdbUnionH.Checked == true)
            {
                bool respuesta = MessageBox.Show("Registro de Esposa/Conyuge o hijos", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (respuesta)
                {
                    frmCargas.ShowDialog();
                }
                else
                {

                }
            } else if (rdbSoltero.Checked == true)
            {
                bool respuesta = MessageBox.Show("¿El colaborador tiene hijos?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (respuesta)
                {
                    frmCargas.ShowDialog();
                }
                else
                {

                }
            }

        }
        private void limpiarCanmpos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtGmap.Clear();
            txtNacionalidad.Clear();
            txtConvencional.Clear();
            txtCodigoIESS.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtCorreo2.Clear();
            txtEdad.Clear();
            txtSueldo.Clear();
            txtCargo.Clear();
            txtReferencias.Clear();
            txtDireccion.Clear();

            cmbContrato.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;

            ptbFoto.Image = null;
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaI.Value = DateTime.Now;
        }

        private void nextTrabajador()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_NextTrabajador", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA",txtCedula.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtCedula.Text = lector["CEDULA"].ToString();
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }finally { conexion.Close(); }
        }

        private void LastTrabajador()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obenerLastTrabajador", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtCedula.Text = lector["CEDULA"].ToString();
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conexion.Close(); }
        }
        private void previousTrabajador()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_previousRegistro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtCedula.Text = lector["CEDULA"].ToString();
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conexion.Close(); }
        }

        private void firstTrabajador()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_firstTrabajador", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtCedula.Text = lector["CEDULA"].ToString();
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conexion.Close(); }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value; //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            txtEdad.Text = edad.ToString();
        }
    }
}