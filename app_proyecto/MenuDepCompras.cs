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
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
            habilitarRegistro();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e) {
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
            habilitarActualizacion();
        }
        
        private void btnMobiliario_Click(object sender, EventArgs e) {
            MobiliarioEquipo mobequip = new MobiliarioEquipo();
            mobequip.Show();
            habilitarRegistroMob();
        }
        
        private void btnReportes_Click(object sender, EventArgs e) {

        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void habilitarRegistro() {
            Proveedor proveedor = new Proveedor();
            proveedor.btnBuscar.Enabled = !proveedor.btnBuscar.Enabled;
            proveedor.btnActualizar.Enabled = !proveedor.btnActualizar.Enabled;
        }

        private void habilitarActualizacion() {
            Proveedor proveedor = new Proveedor();
            proveedor.btnRegistrar.Enabled = !proveedor.btnRegistrar.Enabled;
        }

        private void habilitarRegistroMob() {
            MobiliarioEquipo mobequip = new MobiliarioEquipo();
            mobequip.btnBuscar.Enabled = !mobequip.btnBuscar.Enabled;
            mobequip.btnActualizarE.Enabled = !mobequip.btnActualizarE.Enabled;
            mobequip.btnActualizarM.Enabled = !mobequip.btnActualizarM.Enabled;
        }
    }
}
