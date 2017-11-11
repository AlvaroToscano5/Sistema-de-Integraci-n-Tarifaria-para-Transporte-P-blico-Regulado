using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_proyecto
{
    public partial class MenuGerencia : Form
    {
        public MenuGerencia()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {

        }

        private void btnMobiliarioEquipo_Click(object sender, EventArgs e) {

        }

        private void btnEmpleados_Click(object sender, EventArgs e) {

        }

        private void btnProveedor_Click(object sender, EventArgs e) {

        }

        private void btnMantenimientos_Click(object sender, EventArgs e) {

        }

        private void btnCambio_Click(object sender, EventArgs e) {

        }

        private void btnReclamo_Click(object sender, EventArgs e) {

        }

        private void btnRecaudacion_Click(object sender, EventArgs e) {

        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
