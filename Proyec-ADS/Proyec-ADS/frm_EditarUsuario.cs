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
    public partial class frm_EditarUsuario : Form
    {
        Docente profe = new Docente();

        public frm_EditarUsuario()
        {
            InitializeComponent();
        }

        private void ConsultarDocente()
        {
            Docente  d= new Docente();
            U.DataSource=d.ConsultarDocente();
            U.DisplayMember = "Usuario";
           CN.DataSource = d.ConsultarDocente();
            CN.DisplayMember = "NombreDocente";
            NU.DataSource = d.ConsultarDocente();
            NU.DisplayMember = "ApellidoDocente";
            AU.DataSource = d.ConsultarDocente();
            AU.DisplayMember = "CorreoElectronico";
        }

       


        private void limpiar()
        {
          errorProvider1.SetError(txtCA, "");  
        
          errorProvider1.SetError(txtCC, "");
            
          errorProvider1.SetError(txtNC, "");  
        }

        private bool Validar()
        {
            bool validado = true;
            if (txtCA.Text == "")
            {
                errorProvider1.SetError(txtCA, "Ingrese la contraseña");
                validado = false;
            }
            if (txtNC.Text == "")
            {
                errorProvider1.SetError(txtNC, "Ingrese la contraseña");
                validado = false;
            }
            if (txtCC.Text == "")
            {
                errorProvider1.SetError(txtCC, "Confirmar contraseña");
                validado = false;
            }
            if (txtNC.Text != txtCC.Text)
            {
                errorProvider1.SetError(txtCC, "Las contraseñas no coinciden");
                validado = false;
            }

            return validado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_Editarusuario_Click(object sender, EventArgs e)
        {

        }

        private void frm_EditarUsuario_Load(object sender, EventArgs e)
        {
            ConsultarDocente();
        }

        private void grb_Editarusuarios_Enter(object sender, EventArgs e)
        {

        }

        private void grb_Editarusuarios_Enter_1(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                if (Validar() == true)
                {
                    profe.usuario = Convert.ToString(U.Text);
                    profe.contraseña = txtCC.Text;
                    profe.ModificarUsuario();
                    MessageBox.Show("Cambios realizados con éxito, reinicio de sesión obligatorio", "Mensaje", MessageBoxButtons.OK);
                    Application.Restart();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            pNC.Visible = true;
        }

        private void txtCA_Leave(object sender, EventArgs e)
        {
            if (profe.ComprobarContraseña(txtCA.Text) == true)
            {
                btn_guardar.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {

                errorProvider1.SetError(txtCA, "La contraseña ingresada es incorrecta");
                btn_guardar.Enabled = false;   
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
