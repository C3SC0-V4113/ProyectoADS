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
    public partial class frm_cargando : Form
    {
        public string Mensaje;

        public frm_cargando()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carga.Width += 3;
            if (carga.Width >= 800)
            {
                timer1.Stop();
                frm_menu m = new frm_menu();
                m.MensajeCodigo = Mensaje;
                m.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm_cargando_Load(object sender, EventArgs e)
        {

        }
    }
}
