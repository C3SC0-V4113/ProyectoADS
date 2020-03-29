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



        Conectar con = new Conectar();
        public bool ValidarLogin(string uss, string pass)
        {
            return con.Login(uss, pass);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "Usuario")
            {

                if (txt_contraseña.Text != "Contraseña")
                {

                    var valido = ValidarLogin(txt_usuario.Text, txt_contraseña.Text);
                    if (valido == true)
                    {
                        frm_menu m = new frm_menu();
                        m.Visible = true;
                        this.Visible = false;

                    }
                    else
                    {
                        error("Usuario y/o Contraseña inválidos");
                        txt_usuario.Clear();
                        txt_contraseña.Clear();
                        txt_usuario.Focus();
                    }
                }
                else error("Por favor ingrese la contraseña");
            }
            else
            { error("Por favor ingrese el usuario"); }
           
           
        }

        //MÉTODO ERROR: GENERA EL MENSAJE CONTENIDO EN M, MOSTRÁNDOLO EN LBLERROR
        private void error(string m)
        {
            lblerror.Text = "    " + m;
            lblerror.Visible = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña rec = new frmRecuperarContraseña();
            rec.Visible = true;
            this.Visible = false;

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
