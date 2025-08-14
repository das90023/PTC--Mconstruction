using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Modelo;


namespace Vistas.Formularios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Clientes.cargarClientes();
            dgvClientes.DataSource = Clientes.cargarClientes();
            if (dgvClientes.Columns.Contains("idCliente"))
            {
                dgvClientes.Columns["idCliente"].Visible = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SeleccionAdmin formularioAdmin = new SeleccionAdmin();
            formularioAdmin.Show();
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.NumeroTelefono = txtNumeroTelefono.Text;
            c.CorreoElectronico = txtCorreoElectronico.Text;
            c.Empresa = txtEmpresa.Text;
            c.InsertarClientes();
            MostrarClientes();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           {

                var valorCelda = dgvClientes.CurrentRow?.Cells["idCliente"]?.Value;

                if (valorCelda != null && int.TryParse(valorCelda.ToString(), out int id))
                {
                    Clientes p = new Clientes();

                    if (p.EliminarCliente(id))
                    {
                        MessageBox.Show("Cliente Eliminado");
                        MostrarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar al cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El valor del ID no es válido.");
                }

            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var valorCelda = dgvClientes.CurrentRow?.Cells["idCliente"]?.Value;

            if (valorCelda != null && int.TryParse(valorCelda.ToString(), out int id))
            {
                Clientes c = new Clientes();

                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.NumeroTelefono = txtNumeroTelefono.Text;
                c.CorreoElectronico = txtCorreoElectronico.Text;
                c.Direccion = txtDireccion.Text;
                c.Empresa = txtEmpresa.Text;

                if (c.ActualizarCliente(id))
                {
                    MessageBox.Show("Cliente actualizado correctamente");
                    MostrarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar al cliente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente válido de la tabla para actualizar.");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString();
                txtNumeroTelefono.Text = row.Cells["Telefonó"].Value?.ToString();
                txtCorreoElectronico.Text = row.Cells["Email"].Value?.ToString();
                txtDireccion.Text = row.Cells["Dirección"].Value?.ToString();
                txtEmpresa.Text = row.Cells["Empresa"].Value?.ToString();
            }

        }
    }
  
}
