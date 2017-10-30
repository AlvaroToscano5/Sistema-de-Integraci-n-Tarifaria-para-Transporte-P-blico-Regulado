namespace app_proyecto
{
    partial class ReconocerUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReconocerUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbHuella = new System.Windows.Forms.PictureBox();
            this.lblHuella = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reconocimiento de Usuario";
            // 
            // pbHuella
            // 
            this.pbHuella.Image = ((System.Drawing.Image)(resources.GetObject("pbHuella.Image")));
            this.pbHuella.Location = new System.Drawing.Point(70, 67);
            this.pbHuella.Name = "pbHuella";
            this.pbHuella.Size = new System.Drawing.Size(105, 146);
            this.pbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHuella.TabIndex = 2;
            this.pbHuella.TabStop = false;
            // 
            // lblHuella
            // 
            this.lblHuella.AutoSize = true;
            this.lblHuella.Location = new System.Drawing.Point(82, 48);
            this.lblHuella.Name = "lblHuella";
            this.lblHuella.Size = new System.Drawing.Size(76, 13);
            this.lblHuella.TabIndex = 3;
            this.lblHuella.Text = "Huella Usuario";
            this.lblHuella.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHuella.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(70, 236);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(105, 38);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // ReconocerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 295);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblHuella);
            this.Controls.Add(this.pbHuella);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReconocerUsuario";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbHuella;
        private System.Windows.Forms.Label lblHuella;
        private System.Windows.Forms.Button btnProcesar;
    }
}