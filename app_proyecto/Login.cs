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
                if (dt.Rows[0][0].ToString() == "EEU01") {
                    if (dt.Rows[0][1].ToString() == "A0001") {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE003") {
                            MenuRecursosHumanos humanos = new MenuRecursosHumanos();
                            humanos.Show();
                            humanos.btnReportes.Enabled = !humanos.btnReportes.Enabled;
                            MessageBox.Show("Bienvenido Asistente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                        else {
                            MenuRecursosHumanos humanos = new MenuRecursosHumanos();
                            humanos.Show();
                            MessageBox.Show("Bienvenido Gerente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    } else if (dt.Rows[0][1].ToString() == "A0002") {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE005") {
                            MenuDepCompras compras = new MenuDepCompras();
                            compras.Show();
                            compras.btnReportes.Enabled = !compras.btnReportes.Enabled;
                            MessageBox.Show("Bienvenido Asistente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                        else {
                            MenuDepCompras compras = new MenuDepCompras();
                            compras.Show();
                            MessageBox.Show("Bienvenido Gerente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    }
                    else if (dt.Rows[0][1].ToString() == "A0003") {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE007") {
                            MenuServicioTecnico tecnico = new MenuServicioTecnico();
                            tecnico.Show();
                            tecnico.btnReportes.Enabled = !tecnico.btnReportes.Enabled;
                            MessageBox.Show("Bienvenido Asistente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                        else {
                            MenuServicioTecnico tecnico = new MenuServicioTecnico();
                            tecnico.Show();
                            MessageBox.Show("Bienvenido Gerente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    }
                    else if (dt.Rows[0][1].ToString() == "A0004") {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE009") {
                            MenuCAU cau = new MenuCAU();
                            cau.Show();
                            cau.btnReportes.Enabled = !cau.btnReportes.Enabled;
                            MessageBox.Show("Bienvenido Asistente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                        else {
                            MenuCAU cau = new MenuCAU();
                            cau.Show();
                            MessageBox.Show("Bienvenido Gerente: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    }
                    else if (dt.Rows[0][1].ToString() == "A0005")
                    {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE011") {
                            MenuCajera cajera = new MenuCajera();
                            cajera.Show();
                            MessageBox.Show("Bienvenido Cajero(a): " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    }
                    else  {
                        this.Hide();
                        if (dt.Rows[0][2].ToString() == "TE001") {
                            //Menu Administrador
                            MessageBox.Show("Bienvenido Administrador: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                        else {
                            MenuGerencia gerencia = new MenuGerencia();
                            gerencia.Show();
                            MessageBox.Show("Bienvenido Gerente General: " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString());
                        }
                    }
                }
                else {
                    MessageBox.Show("Empleado Inactivo");
                }
            }
            else {
                MessageBox.Show("Credenciales Incorrectas");
            }

        }
    }
}
