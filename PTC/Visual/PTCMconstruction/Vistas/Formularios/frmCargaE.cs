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
    public partial class frmCargaE : Form
    {
        private string nombreUsuario;

        public frmCargaE(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            this.Load += frmCargaE_Load;
        }

        private async void frmCargaE_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            SeleccionEmpleado seleccion = new SeleccionEmpleado (nombreUsuario);
            seleccion.Show();
            this.Close();
        }
    }
}
