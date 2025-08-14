using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo.Conexion;
using System.IO;
using System.Windows.Forms;

namespace Modelo.Entidades
{
    public class Clientes
    {
        private  string idCliente;
        private  string nombre;
        private  string apellido;
        private  string numeroTelefono;
        private  string correoElectronico;
        private  string direccion;
        private  string empresa;

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Empresa { get => empresa; set => empresa = value; }

        public static DataTable cargarClientes()
        {
            SqlConnection con = ConexionDB.conectar();
            string comando = "SELECT idCliente, nombre as [Nombre], apellido as [Apellido], numeroTelefono as [Telefonó], correoElectronico as [Email], direccion as [Dirección], empresa as [Empresa] FROM Clientes";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
        public bool InsertarClientes()
        {
            SqlConnection con = ConexionDB.conectar();
            string comando = "INSERT INTO Clientes (nombre, apellido, numeroTelefono, correoElectronico, direccion, empresa) " +
                             "VALUES (@nombre, @apellido, @numeroTelefono, @correoElectronico, @direccion, @empresa)";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombre", string.IsNullOrWhiteSpace(Nombre) ? "Sin nombre" : Nombre);
            cmd.Parameters.AddWithValue("@apellido", string.IsNullOrWhiteSpace(Apellido) ? "Sin apellido" : Apellido);
            cmd.Parameters.AddWithValue("@numeroTelefono", string.IsNullOrWhiteSpace(NumeroTelefono) ? "0000000000" : NumeroTelefono);
            cmd.Parameters.AddWithValue("@correoElectronico", string.IsNullOrWhiteSpace(CorreoElectronico) ? "sin@email.com" : CorreoElectronico);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(Direccion) ? "Sin dirección" : Direccion);
            cmd.Parameters.AddWithValue("@empresa", string.IsNullOrWhiteSpace(empresa) ? "Sin empresa" : empresa);

            int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Cliente Añadido Correctamente");
                return true;
            }
            else
            {
                MessageBox.Show("Error, Algo falló");
                return false;
            }

        }
        public bool EliminarCliente(int id)
        {
            SqlConnection con = ConexionDB.conectar();
            string comando = "Delete from Clientes where idCliente = @idCliente";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idCliente", id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarCliente(int id)
        {
            SqlConnection con = ConexionDB.conectar();
            string comando = "UPDATE Clientes SET nombre = @nombre, apellido = @apellido, numeroTelefono = @numeroTelefono, correoElectronico = @correoElectronico, direccion = @direccion, empresa = @empresa WHERE idCliente = @idCliente";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@idCliente", id);
            cmd.Parameters.AddWithValue("@nombre", string.IsNullOrWhiteSpace(Nombre) ? "Sin nombre" : Nombre);
            cmd.Parameters.AddWithValue("@apellido", string.IsNullOrWhiteSpace(Apellido) ? "Sin apellido" : Apellido);
            cmd.Parameters.AddWithValue("@numeroTelefono", string.IsNullOrWhiteSpace(NumeroTelefono) ? "0000000000" : NumeroTelefono);
            cmd.Parameters.AddWithValue("@correoElectronico", string.IsNullOrWhiteSpace(CorreoElectronico) ? "sin@email.com" : CorreoElectronico);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(Direccion) ? "Sin dirección" : Direccion);
            cmd.Parameters.AddWithValue("@empresa", string.IsNullOrWhiteSpace(Empresa) ? "Sin empresa" : Empresa);

            return cmd.ExecuteNonQuery() > 0;
        }

    }
}
