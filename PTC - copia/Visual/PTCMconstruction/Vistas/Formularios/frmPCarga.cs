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
    public partial class frmPCarga : Form
    {
        private string nombreUsuario;

        public frmPCarga(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            this.Load += frmPCarga_Load;
        }

        private async void frmPCarga_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            SeleccionAdmin seleccion = new SeleccionAdmin(nombreUsuario);
            seleccion.Show();
            this.Close();
        }
    }
}
