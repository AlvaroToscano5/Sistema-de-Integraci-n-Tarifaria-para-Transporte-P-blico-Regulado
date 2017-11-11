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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        EmpleadoNegocio empleado = new EmpleadoNegocio();
        EstacionNegocio estacion = new EstacionNegocio();
        AreaNegocio area = new AreaNegocio();
        EstadoNegocio estado = new EstadoNegocio();
        TipoNegocio tipo = new TipoNegocio();

        private void Empleado_Load(object sender, EventArgs e) {
            cargarCombos();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e) {

        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            EmpleadoEntity emp = new EmpleadoEntity();
            //leerDatos(emp);
            emp.codigo = lblCodigo.Text;
            emp.dni = txtDni.Text;
            emp.nombre = txtNombre.Text;
            emp.apellidos = txtApellidos.Text;
            emp.sexo = cboSexo.SelectedItem.ToString();
            emp.correo = txtCorreo.Text;
            emp.edad = int.Parse(txtEdad.Text);
            emp.direccion = txtDireccion.Text;
            emp.telefono = txtTelefono.Text;
            emp.usuario = txtUsuario.Text;
            emp.contraseña = txtContraseña.Text;
            emp.fechaReg = DateTime.Now.ToShortDateString().ToString();
            emp.fechaAct = "";
            emp.tipo = cboTipo.SelectedValue.ToString();
            emp.estado = cboEstado.SelectedValue.ToString();
            emp.estacion = cboEstación.SelectedValue.ToString();
            emp.area = cboArea.SelectedValue.ToString();

            string mensaje = empleado.registrar(emp);
            MessageBox.Show(mensaje);
        }

        private void leerDatos(EmpleadoEntity emp) {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {

        }
        private void cargarCombos() {
            cboEstación.DataSource = estacion.listadoEstacion();
            cboEstación.ValueMember = "codigo";
            cboEstación.DisplayMember = "descripcion";

            cboArea.DataSource = area.listadoArea();
            cboArea.ValueMember = "codigo";
            cboArea.DisplayMember = "descripcion";

            cboEstado.DataSource = estado.listadoEstadoEmpUsu();
            cboEstado.ValueMember = "codigo";
            cboEstado.DisplayMember = "descripcion";

            cboTipo.DataSource = tipo.listadoTipoEmpleado();
            cboTipo.ValueMember = "codigo";
            cboTipo.DisplayMember = "descripcion";
        }
    }
}
