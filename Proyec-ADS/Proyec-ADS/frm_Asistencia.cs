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
using System.Data;

namespace Proyec_ADS
{
    public partial class frm_Asistencia : Form
    {
        public String CodDocente;
        int Identidad;

        public frm_Asistencia()
        {
            InitializeComponent();
            MostrarSalones();
        }

        private void MostrarSalones()
        {
            cmb_materia.SelectedIndex = -1;
            Grupos g = new Grupos();
            cmb_materia.DataSource = g.ListarSalones();
            cmb_materia.DisplayMember = "Nombre de Asignatura";
            cmb_materia.ValueMember = "CodGrupo";
        }

        private void btn_NuevaClase_Click(object sender, EventArgs e)
        {
            if (cmb_materia.SelectedIndex != -1)
            {
                Sesiones sesiones = new Sesiones();
                Asistencias asis = new Asistencias();
                Grupos g = new Grupos();
                string Grupo = cmb_materia.SelectedValue.ToString();
                DateTime fecha = DateTime.Now;
                Identidad = sesiones.CrearSesion(CodDocente, Grupo, fecha);
                dgv_invisible.DataSource = asis.AlumnosSalon(Grupo);
                DateTime Fuchibol = new DateTime(2000, 12, 07);
                for (int fila = 0; fila < dgv_invisible.Rows.Count - 1; fila++)
                {
                    for (int col = 0; col < dgv_invisible.Rows[fila].Cells.Count; col++)
                    {
                        string valor = dgv_invisible.Rows[fila].Cells[col].Value.ToString();
                        asis.CrearAsistencias(Identidad, valor, Fuchibol);
                    }
                }
                ActualizarDGV();
            }
            else
            {
                MessageBox.Show("Seleccione un grupo de clase");
            }
        }

        private void ActualizarDGV()
        {
            Sesiones ses = new Sesiones();
            dgv_asistencia.DataSource = ses.AsistenciaSesion(Identidad);
        }

        private void frm_Asistencia_Load(object sender, EventArgs e)
        {
            dgv_invisible.Visible = false;
        }

        private void btn_marcar_Click(object sender, EventArgs e)
        {
            Asistencias asis = new Asistencias();
            DateTime fechaactual=DateTime.Now.Date.ToLocalTime();
            asis.EditarAsistencias(Identidad, txt_codigo.Text, fechaactual);
            ActualizarDGV();
            MessageBox.Show("Guardado con Exito");
        }
    }
}
