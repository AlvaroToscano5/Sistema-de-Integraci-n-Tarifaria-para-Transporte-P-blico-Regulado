﻿using System;
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
            Empleado empleado = new Empleado();
            empleado.Show();
            habilitarRegistro();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e) {
            Empleado empleado = new Empleado();
            empleado.Show();
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
            Empleado empleado = new Empleado();
            empleado.btnBuscar.Enabled = !empleado.btnBuscar.Enabled;
            empleado.btnActualizar.Enabled = !empleado.btnActualizar.Enabled;
        }

        private void habilitarActualizacion() {
            Empleado empleado = new Empleado();
            empleado.btnRegistrar.Enabled = !empleado.btnRegistrar.Enabled;
        }
    }
}
