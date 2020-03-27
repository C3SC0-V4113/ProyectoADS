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
    class Docente
    {
        private Conexion conex = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public bool ComprobarDocente(string Codigo)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "BuscarCodigoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodDocente", Codigo);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                comando.Parameters.Clear();
                conex.CerrarConexion();
                return true;
            }
            else
            {
                comando.Parameters.Clear();
                conex.CerrarConexion();
                return false;
            }
        }

        public void Insertar(string CodUsuario, string contraseña, string Nombre, string Apellido, string Correo)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "CrearDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodDocente", CodUsuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@NombreDocente", Nombre);
            comando.Parameters.AddWithValue("@ApellidoDocente", Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", Correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string CodUsuario, string contraseña, string Nombre, string Apellido, string Correo)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "EditarDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodDocente", CodUsuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@NombreDocente", Nombre);
            comando.Parameters.AddWithValue("@ApellidoDocente", Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", Correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
