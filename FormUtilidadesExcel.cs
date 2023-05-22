using CrystalDecisions.CrystalReports.Engine;
using ExcelDataReader;
using ProyectoRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRolesConCrystal
{
    public partial class FormUtilidadesExcel : Form
    {
        private DataSet dtsTablas = new DataSet();
        public FormUtilidadesExcel()
        {
            InitializeComponent();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            oOpenFileDialog.Title = "Seleccione el archivo de Excel";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dgvDatos.DataSource = null;

                txtRutaArchivo.Text = oOpenFileDialog.FileName;
                try
                {
                    using (FileStream fsSource = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fsSource, new ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding(1252)
                        });

                        dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        //transformacion a tabla virtual
                        foreach (DataTable tabla in dtsTablas.Tables)
                        {
                            cboHojas.Items.Add(tabla.TableName);
                        }
                        cboHojas.SelectedIndex = 0;
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMostrarHojas_Click(object sender, EventArgs e)
        {
            if (cboHojas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una hoja");
                return;
            }
            dgvDatos.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];
        }

        private void btnSubirTrabajadores_Click(object sender, EventArgs e)
        {
            // Aquí va la funcion de subir datos a la base de datos
            DataTable data = (DataTable)(dgvDatos.DataSource);

            bool resultado = new Operaciones().SubirDatosTrabajadores(data);

            if (resultado)
            {
                MessageBox.Show("Se registro la data");
            }
            else
            {
                MessageBox.Show("Hubo un problema al registrar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteColaboradores ventana = new frmReporteColaboradores();
            ReportDocument report = new ReportDocument();
            string dir = "C:\\Users\\jayala\\source\\repos\\ProyectoRolesConCrystal\\CrystalReport1.rpt";
            report.Load(dir);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
    }
}
 