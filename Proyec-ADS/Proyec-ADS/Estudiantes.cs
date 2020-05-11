using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyec_ADS
{
    class Estudiantes
    {
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
    }
}
