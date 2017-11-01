using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocios;
using System.IO;

namespace app_proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        EmpleadoNegocio empleado = new EmpleadoNegocio();

        private void btnIngresar_Click(object sender, EventArgs e) {

            String usuario = txtUsuario.Text;
            String contrasena = txtContrasena.Text;

            AutenticarCredenciales(usuario, contrasena);
                        
        }

        private void AutenticarCredenciales(String usuario, String contrasena) {

            DataTable dt = new DataTable();
            dt = empleado.iniciarSesion(usuario, contrasena);

            if (dt.Rows.Count == 1) {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "TE001") {
                    MenuCajera cajera = new MenuCajera();
                    cajera.Show();
                }
            }

        }
    }
}
