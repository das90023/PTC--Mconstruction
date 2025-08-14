using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Modelo.Entidades;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        /*corregir  SQL EXPRESS*/
        SqlConnection con = new SqlConnection("Data Source=HP-NEGRA\\SQLEXPRESS;Initial Catalog=PTCMconstruction6;Integrated Security=True");
        /*YA NO*/
        bool mostrarContraseña = false;

        public frmLogin()
        {
            InitializeComponent();

            // Ocultar la contraseña por defecto
            txtPass.UseSystemPasswordChar = true;

            // Configurar el PictureBox para mostrar/ocultar contraseña
            picMostrarPass.Cursor = Cursors.Hand;
            picMostrarPass.Click += picMostrarPass_Click;
        }

        private void picMostrarPass_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar contraseña
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string usuario = txtID.Text.Trim();
            string contraseña = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete ambos campos.");
                return;
            }

            login(usuario, contraseña);
        }

        public void login(string usuario, string contraseña)
        {
            try
            {
                con.Open();

                string query = @"
                SELECT u.nombreUsuario, r.nombreRol 
                FROM Usuario u
                INNER JOIN RolUsuario r ON u.idRol = r.idRolUsuario
                WHERE u.nombreUsuario = @nombreUsuario AND u.pass = @pass";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar, 50).Value = usuario;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = contraseña;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    string nombreUsuario = dt.Rows[0]["nombreUsuario"].ToString();
                    string rol = dt.Rows[0]["nombreRol"].ToString();

                    if (rol == "Administrador")
                    {
                        new frmPCarga(nombreUsuario).Show();
                    }
                    else if (rol == "Vendedor" || rol == "Almacenero" || rol == "Gerente" || rol == "Supervisor")
                    {
                        new frmCargaE(nombreUsuario).Show();
                    }
                    else
                    {
                        MessageBox.Show("Rol no reconocido.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
