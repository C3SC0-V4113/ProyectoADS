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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Usuario")
            {

                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;

            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {

                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.DimGray;

            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "*********")
            {

                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;

            }

        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {

                txt_contraseña.Text = "*********";
                txt_contraseña.ForeColor = Color.DimGray;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_iniciar_Click_1(object sender, EventArgs e)
        {
            //frm_cargando car = new frm_cargando();
            //car.Visible = true;
            //this.Visible = false;
        }
    }
}
