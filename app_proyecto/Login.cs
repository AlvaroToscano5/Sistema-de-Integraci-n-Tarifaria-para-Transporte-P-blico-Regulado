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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e) {

            String usuario = txtUsuario.Text;
            String contrasena = txtContrasena.Text;

            IniciarSesion(usuario, contrasena);
                        
        }

        private void IniciarSesion(String usuario, String contrasena) {

            if (usuario.Equals("Cajera"))
            {
                if (contrasena.Equals("1234"))
                {
                    MenuCajera cajera = new MenuCajera();
                    cajera.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else if (usuario.Equals("Reclutador"))
            {
                if (contrasena.Equals("4321"))
                {
                    MenuRecursosHumanos humanos = new MenuRecursosHumanos();
                    humanos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else if (usuario.Equals("Tecnico"))
            {
                if (contrasena.Equals("6789"))
                {
                    MenuServicioTecnico tecnico = new MenuServicioTecnico();
                    tecnico.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else {
                MessageBox.Show("Usuario Incorrecto");
            }

        }
    }
}
