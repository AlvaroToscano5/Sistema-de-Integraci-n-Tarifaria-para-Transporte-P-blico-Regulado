namespace app_proyecto
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnExtranjero = new System.Windows.Forms.Button();
            this.btnPeruano = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbCodigo.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(201, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 21);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "FICHA DE DATOS";
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(386, 41);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(134, 21);
            this.cboNacionalidad.TabIndex = 58;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(386, 15);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(134, 21);
            this.cboTipo.TabIndex = 57;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(312, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 20);
            this.lblTipo.TabIndex = 56;
            this.lblTipo.Text = "Tipo :";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(272, 43);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(108, 20);
            this.lblNacionalidad.TabIndex = 55;
            this.lblNacionalidad.Text = "Nacionalidad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(386, 15);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(134, 20);
            this.txtEdad.TabIndex = 54;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(272, 15);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 20);
            this.lblEdad.TabIndex = 53;
            this.lblEdad.Text = "Edad :";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "------",
            "Femenina",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(386, 68);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(134, 21);
            this.cboSexo.TabIndex = 52;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(274, 69);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(53, 20);
            this.lblSexo.TabIndex = 51;
            this.lblSexo.Text = "Sexo :";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(116, 68);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(130, 20);
            this.txtApellidos.TabIndex = 50;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(14, 68);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(81, 20);
            this.lblApellidos.TabIndex = 49;
            this.lblApellidos.Text = "Apellidos :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(116, 16);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(130, 20);
            this.txtDNI.TabIndex = 46;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(14, 16);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 20);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "DNI :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(312, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 20);
            this.lblEstado.TabIndex = 162;
            this.lblEstado.Text = "Estado :";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(386, 42);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(134, 21);
            this.cboEstado.TabIndex = 161;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(122, 42);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(134, 20);
            this.txtContraseña.TabIndex = 166;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(14, 42);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(100, 20);
            this.lblContraseña.TabIndex = 165;
            this.lblContraseña.Text = "Contraseña :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(122, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario.TabIndex = 164;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 163;
            this.lblUsuario.Text = "Usuario :";
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.btnBuscar);
            this.gbCodigo.Controls.Add(this.lblCodigo);
            this.gbCodigo.Controls.Add(this.lblNumero);
            this.gbCodigo.Controls.Add(this.btnExtranjero);
            this.gbCodigo.Controls.Add(this.btnPeruano);
            this.gbCodigo.Location = new System.Drawing.Point(12, 46);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(535, 71);
            this.gbCodigo.TabIndex = 167;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(493, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 27);
            this.btnBuscar.TabIndex = 140;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(102, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 20);
            this.lblCodigo.TabIndex = 67;
            this.lblCodigo.Text = "U00000001";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(16, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(33, 20);
            this.lblNumero.TabIndex = 66;
            this.lblNumero.Text = "N° :";
            // 
            // btnExtranjero
            // 
            this.btnExtranjero.Image = ((System.Drawing.Image)(resources.GetObject("btnExtranjero.Image")));
            this.btnExtranjero.Location = new System.Drawing.Point(460, 28);
            this.btnExtranjero.Name = "btnExtranjero";
            this.btnExtranjero.Size = new System.Drawing.Size(27, 27);
            this.btnExtranjero.TabIndex = 65;
            this.btnExtranjero.UseVisualStyleBackColor = true;
            this.btnExtranjero.Click += new System.EventHandler(this.btnExtranjero_Click);
            // 
            // btnPeruano
            // 
            this.btnPeruano.Image = ((System.Drawing.Image)(resources.GetObject("btnPeruano.Image")));
            this.btnPeruano.Location = new System.Drawing.Point(427, 28);
            this.btnPeruano.Name = "btnPeruano";
            this.btnPeruano.Size = new System.Drawing.Size(27, 27);
            this.btnPeruano.TabIndex = 64;
            this.btnPeruano.UseVisualStyleBackColor = true;
            this.btnPeruano.Click += new System.EventHandler(this.btnPeruano_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Controls.Add(this.txtDNI);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblApellidos);
            this.gbDatos.Controls.Add(this.cboNacionalidad);
            this.gbDatos.Controls.Add(this.lblEdad);
            this.gbDatos.Controls.Add(this.txtEdad);
            this.gbDatos.Controls.Add(this.lblNacionalidad);
            this.gbDatos.Controls.Add(this.cboSexo);
            this.gbDatos.Controls.Add(this.lblSexo);
            this.gbDatos.Location = new System.Drawing.Point(12, 123);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(535, 105);
            this.gbDatos.TabIndex = 168;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Básicos";
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.lblUsuario);
            this.gbServicio.Controls.Add(this.txtUsuario);
            this.gbServicio.Controls.Add(this.lblContraseña);
            this.gbServicio.Controls.Add(this.cboEstado);
            this.gbServicio.Controls.Add(this.lblEstado);
            this.gbServicio.Controls.Add(this.txtContraseña);
            this.gbServicio.Controls.Add(this.lblTipo);
            this.gbServicio.Controls.Add(this.cboTipo);
            this.gbServicio.Location = new System.Drawing.Point(12, 234);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(535, 78);
            this.gbServicio.TabIndex = 169;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Datos Servicio";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(49, 338);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 26);
            this.btnRegistrar.TabIndex = 172;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 26);
            this.btnCancelar.TabIndex = 171;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(208, 338);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 26);
            this.btnActualizar.TabIndex = 170;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 376);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbServicio);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Button btnPeruano;
        public System.Windows.Forms.Button btnExtranjero;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtEdad;
        public System.Windows.Forms.ComboBox cboNacionalidad;
        public System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.ComboBox cboTipo;
        public System.Windows.Forms.ComboBox cboEstado;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnActualizar;
    }
}