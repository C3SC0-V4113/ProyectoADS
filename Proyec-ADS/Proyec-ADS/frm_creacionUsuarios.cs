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
        }

        private bool Validar()
        {
            bool validado = true;
            if (txt_codigo.Text == "")
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

            return validado;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (txt_contraseña.Text == txt_verificarcontra.Text)
                {
                    try
                    {
                        profe.Insertar(txt_codigo.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text);
                        MessageBox.Show("Docente Guardado con Exito");
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la base de Datos");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no concuerda");
                }
            }
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
        private void frm_creacionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void ptb_creacionusuarios_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
