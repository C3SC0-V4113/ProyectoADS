using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyec_ADS
{
    public partial class frm_menu : Form
    {
        public string MensajeCodigo;

        public frm_menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            abrirFormsHijos(new frm_bienvenida());
            personalizardiseño();
        }

        private Form formactivo = null;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void abrirFormsHijos(Form hijo)
        {
            if (formactivo != null)
            {
                formactivo.Close();
            }
            formactivo = hijo;
            hijo.TopLevel = false;
            hijo.AutoScroll = true;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelProyeccion.Controls.Add(hijo);
            panelProyeccion.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void CambiarInfo(string Codigo)
        {
            Docente profe=new Docente();
            string cadena = profe.RellenoUsuario(Codigo);
            string[] textos = cadena.Split('-');
            lblnombre.Text = textos[0];
            lblemail.Text = textos[1];
        }

        private void personalizardiseño()
        {
            panel_estudiantes.Visible = false;
            panel_asistencia.Visible = false;
        }

        private void ocultarsubmenu()
        {
            if (panel_estudiantes.Visible == true)
                panel_estudiantes.Visible = false;
            if (panel_asistencia.Visible == true)
                panel_asistencia.Visible = false;
        }

        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new ImportarEx());
            ocultarsubmenu();
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panel_estudiantes);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_registroAlumnos());
            ocultarsubmenu();
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panel_asistencia);
        }

        private void btn_tomarasistencia_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Asistencia());
            ocultarsubmenu();
        }

        private void btn_regasistencia_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Informes());
            ocultarsubmenu();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frm_login log = new frm_login();
                this.FormClosed += log.LogOut;
                this.Close();
            }
        }

        private void btn_acercade_Click(object sender, EventArgs e)
        {
           
           
        }

        private void iconocerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconominimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            CambiarInfo(MensajeCodigo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_EditarUsuario());
            ocultarsubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Creditos());
            ocultarsubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ocultarsubmenu();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void panel_barra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
