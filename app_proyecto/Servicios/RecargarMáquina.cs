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
            rec.monto = Double.Parse(txtMonto.Text);

            UsuarioEntity reg = usuario.listar().Where(u => u.dni == rec.dni).FirstOrDefault();
            rec.usuario = reg.codigo;

            mensaje = recarga.recargar(rec);
            MessageBox.Show(mensaje);
            limpiarCajas();
        }
        private void limpiarCajas() {
            txtDni.Text = "";
            txtMonto.Text = "";
        }
    }
}
