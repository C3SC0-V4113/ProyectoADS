using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Proyec_ADS
{
    class Conexion
    {
        class Conexion
        {
            string cadena = "server=localhost;database=RegistroDeAsistencia;integrated security=true";

            private SqlConnection conexion = new SqlConnection("server=localhost;database=RegistroDeAsistencia;integrated security=true");

            //public Conexion()
            //{
            //    conexion.ConnectionString = cadena;
            //}

            public SqlConnection AbrirConexion()
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }

            public SqlConnection CerrarConexion()
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                return conexion;
            }
        }
    }
}
