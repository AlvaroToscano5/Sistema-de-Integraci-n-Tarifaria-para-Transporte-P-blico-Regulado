namespace app_proyecto
{
    partial class TipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualizar Tipo Usuario";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(12, 66);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(49, 20);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI : ";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(29, 305);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(79, 33);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(91, 66);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(129, 20);
            this.txtDni.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 142);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 20);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo: ";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(91, 141);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(162, 21);
            this.cboTipo.TabIndex = 16;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(16, 181);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(237, 107);
            this.dgvUsuario.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(226, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 27);
            this.btnBuscar.TabIndex = 139;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // TipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 352);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TipoUsuario";
            this.Text = "Tipo de Usuario";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}