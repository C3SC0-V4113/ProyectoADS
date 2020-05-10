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
        private string coddocente;
        private string nombredocente;
        private string correodocente;
        private string Usuario;
        private string Contraseña;


        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string contraseña
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }
        public string Codigo
        {
            get { return coddocente;}
            set { coddocente = value; }
        }

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



        public bool ComprobarContraseña(string Contraseña)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "BuscarContraDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
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







        //CONSULTAR DOCENTE//////////////////
        public DataTable ConsultarDocente()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "ConsultarDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            lector = comando.ExecuteReader();
            Tabla.Load(lector);
            lector.Close();
            conex.CerrarConexion();
            return Tabla;
        }





        public void Insertar(string CodUsuario, string contraseña, string Nombre, string Apellido, string Correo,string Usuario)
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
            comando.Parameters.AddWithValue("@Usuario", Usuario);
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
                while (lector.Read())
                {
                    coddocente = lector.GetString(0);
                }
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


        //modificar contraseña del docente:
        
        public void ModificarUsuario()
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "ModificarDOC";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        //METODO PARA RECUPERAR CONTRASEÑA
        public string RecuperarContraseña(string userRequesting)
        {
            string error="";
            string correocensurado;
            SoporteEmail servicio = new SoporteEmail();
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "RecuperarContraseña";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", userRequesting);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                try
                {
                    string Usuario;
                    string contraseña;
                    string Email;

                    while (lector.Read())
                    {
                        Usuario = lector.GetString(0);
                        contraseña = lector.GetString(1);
                        Email = lector.GetString(2);
                        MessageBox.Show(Usuario + " " + contraseña + " " + Email);
                        string remitente = "SARA-UDB: Recuperación de contraseña";
                        string Cuerpo = "Hola, " + Usuario + " , recientemente solicitaste recuperar tu contraseña.\n" + "Tu contraseña actual es: " + contraseña + "\nPor motivos de seguridad le recomendamos cambiar su contraseña una vez acceda el sistema (esto es opcional).";
                        List<string> destinatario = new List<string> { Email };
                        servicio.sendMail(remitente, Cuerpo, destinatario);
                        correocensurado = CensurarCorreo(Email);
                        error = "Se le ha enviado la contraseña al correo: \n" + correocensurado;
                    }
                    comando.Parameters.Clear();
                    conex.CerrarConexion();
                    return error;
                }
                catch (Exception ex)
                {
                    error = "Ha ocurrido un error al enviar el mensaje \n"+ex.Message;
                    comando.Parameters.Clear();
                    conex.CerrarConexion();
                    return error;
                }
            }
            else
            {
                error = "No se ha encontrado ningun Usuario";
                comando.Parameters.Clear();
                conex.CerrarConexion();
                return error;
            }
        }

        //Metodo que censura el correo al que se envio la contraseña
        private string CensurarCorreo(string correoE)
        {
            List<char> palabracensurada = new List<char>();
            string mailCesnurado;
            Console.WriteLine("Escriba la cadena");
            int contador = 0;
            bool correo = false;
            foreach (char letra in correoE)
            {
                if (letra == char.Parse("@"))
                {
                    correo = true;
                }
                if ((contador == 0) || (contador == 1))
                {
                    palabracensurada.Add(letra);
                }
                else
                {
                    if (correo == false)
                    {
                        palabracensurada.Add(char.Parse("*"));
                    }
                    else
                    {
                        palabracensurada.Add(letra);
                    }
                }
                contador++;
            }
            contador = 0;
            mailCesnurado = string.Join("", palabracensurada.ToArray());
            return mailCesnurado;
        }

        public string RellenoUsuario(string CodDocente)
        {
            string Nombre="";
            string Apellido="";
            string Email="";
            string NombreCompleto="";
            string CadenaCompleta="";
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "LeerNombreMail";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodDocente", CodDocente);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Nombre = lector.GetString(0);
                Apellido = lector.GetString(1);
                Email = lector.GetString(2);
                NombreCompleto = Apellido + ", " + Nombre;
                CadenaCompleta = NombreCompleto + "-" + Email;
            }
            comando.Parameters.Clear();
            conex.CerrarConexion();
            return CadenaCompleta;
        }
    }
}
