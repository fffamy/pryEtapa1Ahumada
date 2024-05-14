namespace pryEtapa1Ahumada
{
    partial class frmEtapa1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctDibujo = new System.Windows.Forms.PictureBox();
            this.pctFirma = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDibujo
            // 
            this.pctDibujo.Location = new System.Drawing.Point(48, 34);
            this.pctDibujo.Name = "pctDibujo";
            this.pctDibujo.Size = new System.Drawing.Size(270, 232);
            this.pctDibujo.TabIndex = 0;
            this.pctDibujo.TabStop = false;
            // 
            // pctFirma
            // 
            this.pctFirma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFirma.Location = new System.Drawing.Point(468, 34);
            this.pctFirma.Name = "pctFirma";
            this.pctFirma.Size = new System.Drawing.Size(270, 232);
            this.pctFirma.TabIndex = 1;
            this.pctFirma.TabStop = false;
            this.pctFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseDown);
            this.pctFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseMove);
            this.pctFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseUp);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(48, 337);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(127, 61);
            this.btnDibujar.TabIndex = 2;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(332, 337);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 61);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(611, 337);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(127, 61);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmEtapa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 431);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.pctFirma);
            this.Controls.Add(this.pctDibujo);
            this.Name = "frmEtapa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 1";
            this.Load += new System.EventHandler(this.frmEtapa1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDibujo;
        private System.Windows.Forms.PictureBox pctFirma;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGrabar;
    }
}

