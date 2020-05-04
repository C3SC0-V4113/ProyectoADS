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
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

        Docente doc = new Docente();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frm_login Log = new frm_login();
            Log.Visible = true;
            this.Visible = false;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            string Mensaje;
            Mensaje = doc.RecuperarContraseña(txtRecuperar.Text);
            label1.Text = Mensaje;
        }
    }
}
