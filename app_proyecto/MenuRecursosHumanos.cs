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
    public partial class MenuRecursosHumanos : Form
    {
        public MenuRecursosHumanos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            RegistrarEmpleado empleado = new RegistrarEmpleado();
            empleado.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            ActualizarEmpleado empleado = new ActualizarEmpleado();
            empleado.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e) {

        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
