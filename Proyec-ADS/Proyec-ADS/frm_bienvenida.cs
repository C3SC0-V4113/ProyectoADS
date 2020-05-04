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
    public partial class frm_bienvenida : Form
    {
        public frm_bienvenida()
        {
            InitializeComponent();
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {

        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {

        }

        private void fecha_hora_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToLongTimeString();
            label_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
