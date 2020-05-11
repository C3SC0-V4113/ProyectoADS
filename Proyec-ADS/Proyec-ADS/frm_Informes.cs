using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyec_ADS
{
    public partial class frm_Informes : Form
    {
        private int edit_indice = -1;

        public frm_Informes()
        {
            InitializeComponent();
            MostrarSalones();
            dtp_fechafinal.MaxDate = DateTime.Now;
            dtp_fechainicial.MaxDate = DateTime.Now;
            dgv_detalleasistencia.AllowUserToAddRows = false;
            dgv_informes.AllowUserToAddRows = false;
        }

        private void MostrarSalones()
        {
            cmb_clase.SelectedIndex = -1;
            Grupos g = new Grupos();
            cmb_clase.DataSource = g.ListarSalones();
            cmb_clase.DisplayMember = "Nombre de Asignatura";
            cmb_clase.ValueMember = "CodGrupo";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Sesiones ses = new Sesiones();
            string CodigoClase = cmb_clase.SelectedValue.ToString();
            dgv_informes.DataSource = ses.Busqueda(CodigoClase, dtp_fechafinal.Value, dtp_fechafinal.Value);
        }

        private void dgv_informes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodigoIdentidad = 0;
            Sesiones ses = new Sesiones();

            DataGridViewRow seleccion = dgv_informes.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_informes.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            if (dgv_informes.SelectedRows.Count > 0)
            {
                CodigoIdentidad = int.Parse(dgv_informes.CurrentRow.Cells["CodSesion"].Value.ToString());
                dgv_detalleasistencia.DataSource = ses.AsistenciaSesion(CodigoIdentidad);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
