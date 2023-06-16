﻿using System;
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

namespace ProyectoRolesConCrystal
{
    public partial class FormSubirTrabajadores : Form
    {
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        public FormSubirTrabajadores()
        {
            InitializeComponent();
            txtNombre.TextChanged += new EventHandler(txtFiltro_TextChanged);
        }
        private void dgvConsultaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(dgvConsultaTabla.SelectedCells[4].Value.ToString());
                txtCedula.Text = dgvConsultaTabla.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvConsultaTabla.SelectedCells[3].Value.ToString();
                txtCargo.Text = dgvConsultaTabla.SelectedCells[5].Value.ToString();
                txtSueldo.Text = dgvConsultaTabla.SelectedCells[6].Value.ToString();
                //txtDiscapacidad.Text = dgvConsultaTabla.SelectedCells[7].Value.ToString();
                txtCorreo.Text = dgvConsultaTabla.SelectedCells[8].Value.ToString();
                dtpFechaI.Value = fecha;
                cmbLocalidad.SelectedValue = dgvConsultaTabla.SelectedCells[1].Value.ToString();
                cmbDepartamento.SelectedValue = dgvConsultaTabla.SelectedCells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void recargarTabla()
        {
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
            dgvConsultaTabla.DataSource = dtTRABAJADORES;
        }
        private void btnAgg_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                double pagoHora = (sueldo/30)/8;
                double H_E25 = Math.Round((pagoHora/4)+pagoHora,2);
                double H_E50 = Math.Round((pagoHora/2) + pagoHora,2);
                double H_E100 = Math.Round((pagoHora)*2,2);
                string add = "insert into TRABAJADORES values (@CEDULA, @IdLocalidad, @IdDepartamento, @NOMBRES, @FECHA_INGRESO, @CARGO, @SUELDO_BASE, @PER_DISCAPACIDAD, @CORREO ,@H_E25, @H_E50, @H_E100, DEFAULT, @FECHA_INACTIVO, @FECHA_REINGRESO,  @DT)";
                SqlCommand comando = new SqlCommand(add, conexion);
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
                comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text.ToUpper());
                comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
                comando.Parameters.AddWithValue("@CARGO", txtCargo.Text.ToUpper());
                comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
                //comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
                comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
                comando.Parameters.AddWithValue("@H_E25", H_E25);
                comando.Parameters.AddWithValue("@H_E50", H_E50);
                comando.Parameters.AddWithValue("@H_E100", H_E100);
                //comando.Parameters.AddWithValue("@ESTADO", DB);
                comando.Parameters.AddWithValue("@FECHA_INACTIVO",DBNull.Value);
                comando.Parameters.AddWithValue("@FECHA_REINGRESO",DBNull.Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void FormSubirTrabajadores_Load(object sender, EventArgs e)
        {
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
            dgvConsultaTabla.DataSource = dtTRABAJADORES;
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
            SqlDataAdapter adaptadorContratos = new SqlDataAdapter(llenarcmbC,conexion);
            adaptadorContratos.Fill(dtContratos);
            cmbContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContrato.DataSource = dtContratos;
            cmbContrato.DisplayMember = "TIPO_CONTRATO";
            cmbContrato.ValueMember = "ID_TIPO_CONTRATO";
            //CAMBIAR FORMATO DATETIMEPICKER
            //dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaI.CustomFormat = "dd-MM-yyyy";
            dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                double pagoHora = (sueldo / 30) / 8;
                double H_E25 = Math.Round((pagoHora / 4) + pagoHora, 2);
                double H_E50 = Math.Round((pagoHora / 2) + pagoHora, 2);
                double H_E100 = Math.Round((pagoHora) * 2, 2);
                int flag = 0;
                string mod = "update TRABAJADORES set Idlocalidad=@Idlocalidad, IdDepartamento=@IdDepartamento, NOMBRES=@NOMBRES," +
                "FECHA_INGRESO=@FECHA_INGRESO, CARGO=@CARGO, SUELDO_BASE=@SUELDO_BASE, PER_DISCAPACIDAD=@PER_DISCAPACIDAD, CORREO=@CORREO " +
                ", H_E25=@H_E25, H_E50=@H_E50, H_E100=@H_E100 where CEDULA=@CEDULA";
                SqlCommand comando = new SqlCommand(mod, conexion);
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
                comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text);
                comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
                comando.Parameters.AddWithValue("@CARGO", txtCargo.Text);
                comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
                //comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
                comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
                comando.Parameters.AddWithValue("@H_E25", H_E25);
                comando.Parameters.AddWithValue("@H_E50", H_E50);
                comando.Parameters.AddWithValue("@H_E100", H_E100);
                //comando.Parameters.AddWithValue("@FECHA_INACTIVO", DBNull.Value);
                //comando.Parameters.AddWithValue("@FECHA_REINGRESO", DBNull.Value);

                flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko
                // Buscamos la fila que deseamos actualizar
                string consulta = "select count(*) from TRABAJADORES where CEDULA=@CEDULA";
                SqlCommand comandoConsulta = new SqlCommand(consulta, conexion);
                comandoConsulta.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                int count = Convert.ToInt32(comandoConsulta.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("La cédula no existe en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko

                    if (flag == 1)
                    {
                        MessageBox.Show("Registro modificado con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (flag == 0)
                    {
                        MessageBox.Show("No se pudo modificar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    recargarTabla();
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
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
                        string consultaBorrar = "DELETE FROM TRABAJADORES WHERE CEDULA=@CEDULA222";
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
                    recargarTabla();
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
            LimpiarDatos();
        }

        private void chkDiscapacidad_CheckedChanged(object sender, EventArgs e)
        {
            txtPorcentajeD.Enabled = chkDiscapacidad.Checked;
            label10.Enabled = chkDiscapacidad.Checked;
            label11.Enabled = chkDiscapacidad.Checked;
            cmbDiscapacidad.Enabled = chkDiscapacidad.Checked;
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNombre.Text.Trim(); // Obtener el texto del TextBox y quitar espacios en blanco

            // Obtener la tabla que se utiliza como fuente de datos del DataGridView
            DataTable tabla = ((DataTable)dgvConsultaTabla.DataSource);

            // Si el filtro está vacío, se quita el filtro y se muestran todos los datos
            if (string.IsNullOrEmpty(filtro))
            {
                tabla.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // Se ajusta el filtro según la columna que quieras filtrar, en este ejemplo se filtra por la columna "Nombre"
                tabla.DefaultView.RowFilter = $"NOMBRES LIKE '%{filtro}%'";
            }

            // Actualizar el DataGridView
            dgvConsultaTabla.Refresh();
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
            DialogResult respuesta = MessageBox.Show("¿Está seguro de inactivar al trabajador?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
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
                    recargarTabla();
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
                    recargarTabla();
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
                    if ((txtCedula.Text).Length == 10)
                    {
                        if (verificarCedula == true)
                        {
                            MessageBox.Show("Numero de cedula valido", "Cedula valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                if(verificarCedula == false)
                    {
                           MessageBox.Show("Numero de cedula no valido", "Cedula no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void txtPorcentajeD_Leave(object sender, EventArgs e)
        {
            int porcentajeIngresado = Convert.ToInt32(txtPorcentajeD.Text);
            if (porcentajeIngresado < 30)
            {
                MessageBox.Show("No cumple con el % minimo de discapacidad","No califica",MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkDiscapacidad.Checked = false;
                cmbDiscapacidad.SelectedIndex = 0;
                txtPorcentajeD.Text = "";
            }
        }

        private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value; //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            txtEdad.Text = edad.ToString();
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            ValidarCedula validarCedula = new ValidarCedula();
            bool verificarCedula = validarCedula.P_Valida_Cedula(txtCedula.Text);
            if (chkPasaporte.Checked == false)
            {
                if (verificarCedula == false)
                {
                    MessageBox.Show("Numero de cedula no valido", "Cedula no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}