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
    public partial class frm_creacionUsuarios : Form
    {
        Docente profe = new Docente();
 
        public frm_creacionUsuarios()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_correo.Clear();
            txt_contraseña.Clear();
            txt_verificarcontra.Clear();
            txtUsuario.Clear();
        }

        private bool Validar()
        {
            bool validado = true;
            if (txt_codigo.Text == "")
            {
                errorProvider1.SetError(txt_codigo, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txt_codigo, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txt_contraseña.Text == "")
            {
                errorProvider1.SetError(txt_contraseña, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txt_verificarcontra.Text == "")
            {
                errorProvider1.SetError(txt_verificarcontra, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txt_nombre.Text == "")
            {
                errorProvider1.SetError(txt_nombre, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txt_apellido.Text == "")
            {
                errorProvider1.SetError(txt_apellido, "Porfavor llenar los datos requeridos");
                validado = false;
            }
            if (txt_correo.Text == "")
            {
                errorProvider1.SetError(txt_apellido, "Porfavor llenar los datos requeridos");
                validado = false;
            }

            return validado;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (profe.ComprobarDocente(txt_codigo.Text) == true)
            {
                errorProvider1.SetError(txt_codigo, "Codigo ya existente");
                btn_guardar.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btn_guardar.Enabled = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_CodigoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void grb_Creaciondeusuarios_Enter(object sender, EventArgs e)
        {

        }

        private void txt_verificarcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            frm_login log = new frm_login();
            log.Visible = true;
            this.Visible = false;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (txt_contraseña.Text == txt_verificarcontra.Text)
                {
                    try
                    {
                        profe.Insertar(txt_codigo.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text, txtUsuario.Text);
                        MessageBox.Show("Docente Guardado con Exito, se requiere inicio de sesión");
                        Application.Restart();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no concuerda");
                }
            }
        }
    }
}
