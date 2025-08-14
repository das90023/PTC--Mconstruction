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

namespace Vistas.Formularios
{
    public partial class SeleccionAdmin : Form
    {
        private string nombreUsuario;

        public SeleccionAdmin()
        {
            InitializeComponent();
        }

        public SeleccionAdmin(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            frmLogin formularioAdmin = new frmLogin();
            formularioAdmin.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formularioAdmin = new frmClientes();
            formularioAdmin.Show();
            this.Hide();
        }
    }
}
