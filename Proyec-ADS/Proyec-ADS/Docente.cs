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
            conex.CerrarConexion();
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
            conex.CerrarConexion();
        }

        public bool Login(string uss, string pass)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "InicioSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Usuario", uss);
            comando.Parameters.AddWithValue("@Contraseña", pass);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                comando.Parameters.Clear();
                MessageBox.Show("Validado!");
                conex.CerrarConexion();
                return true;
            }
            else
            {
                comando.Parameters.Clear();
                MessageBox.Show("Neles pasteles");
                conex.CerrarConexion();
                return false;
            }
        }

        //METODO PARA RECUPERAR CONTRASEÑA
        public string RecuperarContraseña(string userRequesting)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "select NombreDocente,ApellidoDocente,Usuario,Email,Pass=CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('password',pass)) from DOCENTES where Usuario=@User or Email=@correo";
            comando.Parameters.AddWithValue("@User", userRequesting);
            comando.Parameters.AddWithValue("@correo", userRequesting);
            comando.Parameters.AddWithValue("@contra", userRequesting);
            comando.CommandType = CommandType.Text;
            lector = comando.ExecuteReader();
            if (lector.Read() == true)
            {
                string userName = lector.GetString(0) + " " + lector.GetString(1);
                string userMail = lector.GetString(3);
                string accountPassword = lector.GetString(4);
                var mailService = new SoporteEmail();
                mailService.sendMail(
                  subject: "SARA-UDB: Recuperación de contraseña",
                  body: "Hola, " + userName + " , recientemente solicitaste recuperar tu contraseña.\n" +
                  "Tu contraseña actual es: " + accountPassword +
                  "\nPor motivos de seguridad le recomendamos cambiar su contraseña una vez acceda el sistema (esto es opcional).",
                  recipientMail: new List<string> { userMail }
                  );
                conex.CerrarConexion();
                return "Hola, " + userName + ", recientemente solicitaste recuperar tu contraseña.\n" +
                  "Por favor revisa tu correo." +
                  "\nPor motivos de seguridad le recomendamos cambiar su contraseña una vez acceda el sistema (esto es opcional).";
            }
            else
            {
                conex.CerrarConexion();
                return "Lo sentimos, no posee una cuenta de correo electrónico asociado a este usuario";
            }
        }
    }
}
