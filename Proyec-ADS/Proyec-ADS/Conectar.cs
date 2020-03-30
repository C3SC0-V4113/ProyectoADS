using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyec_ADS
{
    class Conectar
    {
        //CADENA DE CONEXIÓN
        static public string CadenaConexion = "Server=(local);DataBase=RegistroDeAsistencia;Integrated Security=true";
        public SqlConnection Conexion = new SqlConnection(CadenaConexion);
        private readonly string conectionString;
        //FUNCIÓN
        public Conectar()
        {
            conectionString = CadenaConexion;
        }
        protected SqlConnection getconection()
        {

            return new SqlConnection(conectionString);
        }

        //ABRIENDO CONEXION
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

        }

        //CERRANDO CONEXION

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


        //VALIDAR LOGIN ENCRIPTADO
        public bool Login(string uss, string pass)
        {
            //VALIDANDO CONEXION
            using (var connection = getconection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //EJECUTANDO CONSULTA SQL Y DESENCRIPTANDO
                    command.Connection = connection;
                    command.CommandText = "select Usuario,Pass=CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('password',pass)) from DOCENTES where Usuario=@user and CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('password',Pass))=@contra";
                    command.Parameters.AddWithValue("@User", uss);
                    command.Parameters.AddWithValue("@contra", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }


        //METODO PARA RECUPERAR CONTRASEÑA
             public string recoverPassword(string userRequesting)
                {
          using (var connection = getconection())
    {
      connection.Open();
      using (var command = new SqlCommand())
      {        command.Connection = connection;
        command.CommandText = "select NombreDocente,ApellidoDocente,Usuario,Email,Pass=CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('password',pass)) from DOCENTES where Usuario=@User or Email=@correo";
        command.Parameters.AddWithValue("@User", userRequesting);
        command.Parameters.AddWithValue("@correo", userRequesting);
        command.Parameters.AddWithValue("@contra", userRequesting);
        command.CommandType = CommandType.Text;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read() == true)
        {
          string userName = reader.GetString(0) + " " + reader.GetString(1);
          string userMail = reader.GetString(3);
          string accountPassword = reader.GetString(4);
          var mailService = new SoporteEmail();
          mailService.sendMail(
            subject: "SARA-UDB: Recuperación de contraseña",
            body: "Hola, " + userName + " , recientemente solicitaste recuperar tu contraseña.\n" +
            "Tu contraseña actual es: " + accountPassword +
            "\nPor motivos de seguridad le recomendamos cambiar su contraseña una vez acceda el sistema (esto es opcional).",
            recipientMail: new List<string> { userMail }
            );
          return "Hola, " + userName + ", recientemente solicitaste recuperar tu contraseña.\n" +
            "Por favor revisa tu correo." +
            "\nPor motivos de seguridad le recomendamos cambiar su contraseña una vez acceda el sistema (esto es opcional).";
        }
        else
          return "Lo sentimos, no posee una cuenta de correo electrónico asociado a este usuario";
      }
    }



        }
    }
}

    

