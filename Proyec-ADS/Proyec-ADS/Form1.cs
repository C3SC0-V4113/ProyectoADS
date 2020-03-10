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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizardiseño();
        }
        private void personalizardiseño()
        {
            panel_estudiantes.Visible = false;
            panel_asistencia.Visible=false;

        }
        private void ocultarsubmenu()
        {
            if (panel_estudiantes.Visible == true)
                panel_estudiantes.Visible = false;
            if (panel_asistencia.Visible == true)
                panel_asistencia.Visible= false;
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

       private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panel_estudiantes);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ////
            ocultarsubmenu();
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panel_asistencia);
        }

        private void btn_tomarasistencia_Click(object sender, EventArgs e)
        {
            ////
            ocultarsubmenu();
        }

        private void btn_regasistencia_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void fecha_hora_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToLongTimeString();
            label_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_acercade_Click(object sender, EventArgs e)
        {

        }
    }
}
