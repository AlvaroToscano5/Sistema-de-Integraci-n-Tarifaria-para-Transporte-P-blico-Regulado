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
    public partial class MenuCAU : Form
    {
        public MenuCAU()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            usuario.Show();
            habilitarRegistro();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            usuario.Show();
            habilitarActualizacion();
        }

        private void btnReportes_Click(object sender, EventArgs e) {

        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void habilitarRegistro() {
            Usuario usuario = new Usuario();
            usuario.btnBuscar.Enabled = !usuario.btnBuscar.Enabled;
            usuario.btnActualizar.Enabled = usuario.btnActualizar.Enabled;
        }

        private void habilitarActualizacion() {
            Usuario usuario = new Usuario();
            usuario.btnPeruano.Enabled = !usuario.btnPeruano.Enabled;
            usuario.btnExtranjero.Enabled = !usuario.btnExtranjero.Enabled;
            usuario.btnRegistrar.Enabled = !usuario.btnRegistrar.Enabled;
        }
    }
}
