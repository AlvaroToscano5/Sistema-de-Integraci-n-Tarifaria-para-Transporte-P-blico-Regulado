namespace app_proyecto
{
    partial class MenuCajera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCajera));
            this.btnSaldos = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.lblSaldos = new System.Windows.Forms.Label();
            this.lblReclamos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaldos
            // 
            this.btnSaldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btnSaldos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaldos.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldos.Image")));
            this.btnSaldos.Location = new System.Drawing.Point(250, 97);
            this.btnSaldos.Name = "btnSaldos";
            this.btnSaldos.Size = new System.Drawing.Size(150, 150);
            this.btnSaldos.TabIndex = 1;
            this.btnSaldos.UseVisualStyleBackColor = false;
            this.btnSaldos.Click += new System.EventHandler(this.btnSaldos_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btnReclamos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReclamos.Image = ((System.Drawing.Image)(resources.GetObject("btnReclamos.Image")));
            this.btnReclamos.Location = new System.Drawing.Point(447, 97);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(150, 150);
            this.btnReclamos.TabIndex = 2;
            this.btnReclamos.UseVisualStyleBackColor = false;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(49, 97);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 150);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.lblActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizar.ForeColor = System.Drawing.Color.White;
            this.lblActualizar.Location = new System.Drawing.Point(43, 74);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(165, 20);
            this.lblActualizar.TabIndex = 4;
            this.lblActualizar.Text = "Actualizar Usuarios";
            // 
            // lblSaldos
            // 
            this.lblSaldos.AutoSize = true;
            this.lblSaldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.lblSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldos.ForeColor = System.Drawing.Color.White;
            this.lblSaldos.Location = new System.Drawing.Point(253, 74);
            this.lblSaldos.Name = "lblSaldos";
            this.lblSaldos.Size = new System.Drawing.Size(143, 20);
            this.lblSaldos.TabIndex = 5;
            this.lblSaldos.Text = "Recargar Saldos";
            // 
            // lblReclamos
            // 
            this.lblReclamos.AutoSize = true;
            this.lblReclamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.lblReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclamos.ForeColor = System.Drawing.Color.White;
            this.lblReclamos.Location = new System.Drawing.Point(443, 74);
            this.lblReclamos.Name = "lblReclamos";
            this.lblReclamos.Size = new System.Drawing.Size(159, 20);
            this.lblReclamos.TabIndex = 6;
            this.lblReclamos.Text = "Generar Reclamos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(526, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 24);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "CERRAR SESIÓN";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuCajera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(641, 322);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblReclamos);
            this.Controls.Add(this.lblSaldos);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnReclamos);
            this.Controls.Add(this.btnSaldos);
            this.Name = "MenuCajera";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaldos;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Label lblSaldos;
        private System.Windows.Forms.Label lblReclamos;
        private System.Windows.Forms.Button btnCerrar;
    }
}