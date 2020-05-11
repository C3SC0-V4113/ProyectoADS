using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Proyec_ADS
{
    class Alumno
    {
        private string CodCarnet;
        private string NombreAlumno;
        private string ApellidoAlumno;
        private string CorreoAlumno;
        public string codCarnet
        {
            get { return CodCarnet; }
            set { CodCarnet = value; }
        }
        public string nombreAlumno
        {
            get { return NombreAlumno; }
            set { NombreAlumno = value; }
        }

        public string apellidoAlumno
        {
            get { return ApellidoAlumno; }
            set { ApellidoAlumno = value; }
        }
        public string correoAlumno
        {
            get { return CorreoAlumno; }
            set { CorreoAlumno = value; }
        }
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public void AgregarAlmno(string codCarnet, string nombreAlumno, string apellidoAlumno, string correoAlumno)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "CrearEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodCarnet", codCarnet);
            comando.Parameters.AddWithValue("@NombreAlumno", nombreAlumno);
            comando.Parameters.AddWithValue("@ApellidoAlumno", apellidoAlumno);
            comando.Parameters.AddWithValue("@CorreoAlumno",correoAlumno);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conex.CerrarConexion();
        }

    }
}
