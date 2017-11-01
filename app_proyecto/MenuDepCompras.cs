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
    public partial class MenuDepCompras : Form
    {
        public MenuDepCompras()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            RegistrarProveedor proveedor = new RegistrarProveedor();
            proveedor.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            ActualizarProveedor proveedor = new ActualizarProveedor();
            proveedor.Show();
        }

        private void btnMobiliario_Click(object sender, EventArgs e) {
            RegistrarMobiliarioEquipo mobequip = new RegistrarMobiliarioEquipo();
            mobequip.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {

        }
    }
}
