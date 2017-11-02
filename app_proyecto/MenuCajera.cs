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
    public partial class MenuCajera : Form
    {
        public MenuCajera()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            TipoUsuario tipousuario = new TipoUsuario();
            tipousuario.Show();
        }

        private void btnSaldos_Click(object sender, EventArgs e) {
            RecargarSaldo saldo = new RecargarSaldo();
            saldo.Show();
        }

        private void btnReclamos_Click(object sender, EventArgs e) {
            GenerarReclamo reclamo = new GenerarReclamo();
            reclamo.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
