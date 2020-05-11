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
    class Asistencias
    {
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Alumnos = new DataTable();

        public DataTable AlumnosSalon(string CodGrupo)
        {
            try
            {
                comando.Connection = conex.AbrirConexion();
                comando.CommandText = "AlumnosDeSalon";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodGrupo", CodGrupo);
                lector = comando.ExecuteReader();
                Alumnos.Load(lector);
                lector.Close();
                conex.CerrarConexion();
                return Alumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }
        }

        public void CrearAsistencias(int CodSesion, string CodCarnet, DateTime HoraEntrada)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "CrearAsistencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodSesion", CodSesion);
            comando.Parameters.AddWithValue("@CodCarnet", CodCarnet);
            comando.Parameters.AddWithValue("@HoraEntrada", HoraEntrada);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conex.CerrarConexion();
        }

        public void EditarAsistencias(int CodSesion, string CodCarnet, DateTime HoraEntrada)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "EditarAsistencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodSesion", CodSesion);
            comando.Parameters.AddWithValue("@CodCarnet", CodCarnet);
            comando.Parameters.AddWithValue("@HoraEntrada", HoraEntrada);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conex.CerrarConexion();
        }
    }
}
