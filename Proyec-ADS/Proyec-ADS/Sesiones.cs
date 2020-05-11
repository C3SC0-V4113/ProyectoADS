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
    class Sesiones
    {
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Alumnos = new DataTable();

        public DataTable AsistenciaSesion(int CodSesion)
        {
            try
            {
                comando.Connection = conex.AbrirConexion();
                comando.CommandText = "MostrarAsistencia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodSesion", CodSesion);
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

        public DataTable Busqueda(string CodGrupo, DateTime inicial, DateTime final)
        {
            try
            {
                DataTable Busqueda = new DataTable();
                comando.Connection = conex.AbrirConexion();
                comando.CommandText = "BusquedaFecha";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodGrupo", CodGrupo);
                comando.Parameters.AddWithValue("@FechaInicial", inicial);
                comando.Parameters.AddWithValue("@FechaFinal", final);
                lector = comando.ExecuteReader();
                Busqueda.Load(lector);
                lector.Close();
                conex.CerrarConexion();
                return Busqueda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }
        }

        public int CrearSesion(string CodDocente, string CodGrupo, DateTime fecha)
        {
            int identidad = 0;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "CrearSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodDocente", CodDocente);
            comando.Parameters.AddWithValue("@CodGrupo", CodGrupo);
            comando.Parameters.AddWithValue("@FechaSesion", fecha);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                try
                {
                    while (lector.Read())
                    {
                        identidad = int.Parse(lector.GetDecimal(0).ToString());
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la identidad: "+ex);
                }
                comando.Parameters.Clear();
                conex.CerrarConexion();
                return identidad;
            }
            else
            {
                comando.Parameters.Clear();
                conex.CerrarConexion();
                return identidad;
            }
        }
    }
}
