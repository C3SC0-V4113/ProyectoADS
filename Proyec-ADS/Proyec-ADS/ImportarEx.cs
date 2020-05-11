using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using System.Data.SqlClient;

namespace Proyec_ADS
{
    public partial class ImportarEx : Form
    {
        static public string CadenaConexion = "Server=(local);DataBase=RegistroDeAsistencia;Integrated Security=true";
        public SqlConnection conex = new SqlConnection(CadenaConexion);
        SqlCommand comando = new SqlCommand();
        public ImportarEx()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    cb.Enabled = true;
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (ofd.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    result = reader.AsDataSet();
                    cb.Items.Clear();
                    //para seleccionar la hoja de calculo
                    foreach (DataTable dt in result.Tables)
                        cb.Items.Add(dt.TableName);
                    BtnI.Visible = true;
                    reader.Close();
                }
            }
        }

        private void ImportarEx_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        DataSet result;
        private void BtnI_Click(object sender, EventArgs e)
        {
            SqlCommand exportar = new SqlCommand("insert into Estudiantes values ('@CodCarnet','@NombreAlumno','@ApellidoAlumno','@CorreoAlumno')", conex);
            conex.Open();
         try {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    exportar.Parameters.Clear();
                    exportar.Parameters.AddWithValue("@CodCarnet", Convert.ToString(row.Cells["Column0"]));
                    exportar.Parameters.AddWithValue("@NombreAlumno", Convert.ToString(row.Cells["Column1"]));
                    exportar.Parameters.AddWithValue("@ApellidoAlumno", Convert.ToString(row.Cells["Column2"]));                                  
                    exportar.Parameters.AddWithValue("@CorreoAlumno", Convert.ToString(row.Cells["Column3"]));
                    exportar.ExecuteNonQuery();

                }
               
                MessageBox.Show("Base de datos exportada con éxito");
            }
        catch(Exception ex){
            MessageBox.Show(ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }}   
    
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = result.Tables[cb.SelectedIndex];
        }
    }
}
