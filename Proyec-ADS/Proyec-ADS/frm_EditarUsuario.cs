﻿using System;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == txt_verificarcontra.Text)
            {
                profe.Editar("VC190544", txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text);
            }
            else
            {
                MessageBox.Show("La contraseña no concuerda");
            }
        }
    }
}
