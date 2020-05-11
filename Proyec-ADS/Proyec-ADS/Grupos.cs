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
    class Grupos
    {
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Salones = new DataTable();

        public DataTable ListarSalones()
        {
            try
            {
                comando.Connection = conex.AbrirConexion();
                comando.CommandText = "MostrarGrupos";
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                Salones.Load(lector);
                lector.Close();
                conex.CerrarConexion();
                return Salones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                return null;
            }
        }
    }
}
