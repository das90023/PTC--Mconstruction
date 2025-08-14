using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    public class ConexionDB
    {
        /*TAMBIEN CAMBIARLO*/
        private static string servidor = "HP-NEGRA\\SQLEXPRESS";
        private static string baseDeDatos = "PTCMconstruction6";

        public static SqlConnection conectar()
        {
            string cadena = $"Data Source = {servidor}; Initial Catalog = {baseDeDatos}; Integrated Security = true";

            SqlConnection conectar = new SqlConnection(cadena) ;
            conectar.Open();
            return conectar ;
        }
    }
}
