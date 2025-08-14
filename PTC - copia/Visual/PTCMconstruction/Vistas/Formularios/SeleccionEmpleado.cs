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
    public partial class SeleccionEmpleado : Form
    {
        private string nombreUsuario;

        public SeleccionEmpleado()
        {
            InitializeComponent();
        }

        public SeleccionEmpleado(string usuario)
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes2 formularioAdmin = new frmClientes2();
            formularioAdmin.Show();
            this.Hide();
        }
    }
}
