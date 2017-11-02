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
    public partial class MenuServicioTecnico : Form
    {
        public MenuServicioTecnico()
        {
            InitializeComponent();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e) {
            SolicitudMantenimiento mantenimiento = new SolicitudMantenimiento();
            mantenimiento.Show();
        }

        private void btnCambio_Click(object sender, EventArgs e) {
            SolicitudCambio cambio = new SolicitudCambio();
            cambio.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            MobiliarioEquipo mobequip = new MobiliarioEquipo();
            mobequip.Show();
            habilitarActualizacion();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void habilitarActualizacion() {
            MobiliarioEquipo mobequip = new MobiliarioEquipo();
            mobequip.btnRegistrarE.Enabled = !mobequip.btnRegistrarE.Enabled;
            mobequip.btnRegistrarM.Enabled = !mobequip.btnRegistrarM.Enabled;
        }
    }
}
