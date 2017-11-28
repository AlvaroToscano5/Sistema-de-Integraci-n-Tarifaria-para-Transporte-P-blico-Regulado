using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using Entidades;

namespace app_proyecto {
    public partial class RecargarMáquina : Form {
        public RecargarMáquina() {
            InitializeComponent();
        }

        RecargaNegocio recarga = new RecargaNegocio();
        UsuarioNegocio usuario = new UsuarioNegocio();
    

        private void btn1_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e) {
            txtDni.Text = txtDni.Text + "0";
        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            string mensaje = "";
            
            RecargaEntity rec = new RecargaEntity();
            rec.codigo = recarga.generarCodigo();
            rec.fechaReg = DateTime.Now.ToShortDateString().ToString();
            rec.dni = txtDni.Text;

            if (txtMonto.Text.Contains(".")) {
                rec.monto = Decimal.Parse(txtMonto.Text);
            } else {
                rec.monto = Decimal.Parse(txtMonto.Text + ".0");
            }

            UsuarioEntity reg = usuario.listar().Where(u => u.dni == rec.dni).FirstOrDefault();
            rec.usuario = reg.codigo;

            mensaje = recarga.recargar(rec);
            
            MessageBox.Show(mensaje);
            limpiarCajas();
            habilitarBotones();
        }
        private void btnBorrar_Click(object sender, EventArgs e) {
            int final = txtDni.Text.LastIndexOf("");
            string valor = txtDni.Text.Remove(final);
            txtDni.Text = valor;
            btnGrabar.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e) {
            if (usuario.listar().Where(u => u.dni == txtDni.Text).Count() != 0) {
                UsuarioEntity reg = usuario.listar().Where(u => u.dni == txtDni.Text).FirstOrDefault();
                DialogResult result = MessageBox.Show(reg.nombre + " " +reg.apellidos, "¿Nombre Correcto?", MessageBoxButtons.YesNo);
                switch (result) {
                    case DialogResult.Yes: btnGrabar.Enabled = true ; deshabilitarBotones(); break;
                    case DialogResult.No: break;
                }
            } else {
                MessageBox.Show("DNI Ingresado, No Existe");
            }
        }

        private void limpiarCajas() {
            txtDni.Text = "";
            txtMonto.Text = "";
        }
        private void deshabilitarBotones() {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnBorrar.Enabled = false;
        }
        private void habilitarBotones() {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            btnBorrar.Enabled = true;
            btnGrabar.Enabled = false;
        }
    }
}
