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
    public partial class frm_registroAlumnos : Form
    {
        public frm_registroAlumnos()
        {
            InitializeComponent();
        }
        Alumno al = new Alumno();
        private void lbl_Carnet_Click(object sender, EventArgs e)
        {

        }

        public void limp() {
            txt_carnet.Clear();
            txt_nombre.Clear();
            txt_correo.Clear();
            txt_apellido.Clear();
        }

        private void btn_registraralumno_Click(object sender, EventArgs e)
        {
            try
            {
                al.AgregarAlmno(txt_carnet.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text);
                MessageBox.Show("Alumno Guardado con Exito, se requiere inicio de sesión");
                limp();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_registroAlumnos_Load(object sender, EventArgs e)
        {

        }

       

       
      
    }
}
