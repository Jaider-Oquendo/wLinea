namespace wLineas
{
    partial class fmrLinea
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
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblXfinal = new System.Windows.Forms.Label();
            this.lblYinicil = new System.Windows.Forms.Label();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.txtXinicial = new System.Windows.Forms.TextBox();
            this.txtXfinal = new System.Windows.Forms.TextBox();
            this.txtYinicial = new System.Windows.Forms.TextBox();
            this.txtYfinal = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.lblCantidadDeLineas = new System.Windows.Forms.Label();
            this.txtCantidadDeLineas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Location = new System.Drawing.Point(71, 55);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(43, 13);
            this.lblXinicial.TabIndex = 0;
            this.lblXinicial.Text = "X inicial";
            // 
            // lblXfinal
            // 
            this.lblXfinal.AutoSize = true;
            this.lblXfinal.Location = new System.Drawing.Point(71, 116);
            this.lblXfinal.Name = "lblXfinal";
            this.lblXfinal.Size = new System.Drawing.Size(36, 13);
            this.lblXfinal.TabIndex = 1;
            this.lblXfinal.Text = "X final";
            // 
            // lblYinicil
            // 
            this.lblYinicil.AutoSize = true;
            this.lblYinicil.Location = new System.Drawing.Point(270, 55);
            this.lblYinicil.Name = "lblYinicil";
            this.lblYinicil.Size = new System.Drawing.Size(43, 13);
            this.lblYinicil.TabIndex = 2;
            this.lblYinicil.Text = "Y inicial";
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Location = new System.Drawing.Point(277, 116);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(36, 13);
            this.lblYfinal.TabIndex = 3;
            this.lblYfinal.Text = "Y final";
            // 
            // txtXinicial
            // 
            this.txtXinicial.Location = new System.Drawing.Point(130, 55);
            this.txtXinicial.Name = "txtXinicial";
            this.txtXinicial.Size = new System.Drawing.Size(112, 20);
            this.txtXinicial.TabIndex = 4;
            // 
            // txtXfinal
            // 
            this.txtXfinal.Location = new System.Drawing.Point(130, 116);
            this.txtXfinal.Name = "txtXfinal";
            this.txtXfinal.Size = new System.Drawing.Size(112, 20);
            this.txtXfinal.TabIndex = 5;
            // 
            // txtYinicial
            // 
            this.txtYinicial.Location = new System.Drawing.Point(362, 52);
            this.txtYinicial.Name = "txtYinicial";
            this.txtYinicial.Size = new System.Drawing.Size(112, 20);
            this.txtYinicial.TabIndex = 6;
            // 
            // txtYfinal
            // 
            this.txtYfinal.Location = new System.Drawing.Point(362, 116);
            this.txtYfinal.Name = "txtYfinal";
            this.txtYfinal.Size = new System.Drawing.Size(112, 20);
            this.txtYfinal.TabIndex = 7;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(110, 202);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(132, 33);
            this.btnDibujarLinea.TabIndex = 8;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // lblCantidadDeLineas
            // 
            this.lblCantidadDeLineas.AutoSize = true;
            this.lblCantidadDeLineas.Location = new System.Drawing.Point(323, 202);
            this.lblCantidadDeLineas.Name = "lblCantidadDeLineas";
            this.lblCantidadDeLineas.Size = new System.Drawing.Size(94, 13);
            this.lblCantidadDeLineas.TabIndex = 9;
            this.lblCantidadDeLineas.Text = "Cantidad de lineas";
            // 
            // txtCantidadDeLineas
            // 
            this.txtCantidadDeLineas.Location = new System.Drawing.Point(315, 218);
            this.txtCantidadDeLineas.Name = "txtCantidadDeLineas";
            this.txtCantidadDeLineas.Size = new System.Drawing.Size(112, 20);
            this.txtCantidadDeLineas.TabIndex = 10;
            // 
            // fmrLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidadDeLineas);
            this.Controls.Add(this.lblCantidadDeLineas);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtYfinal);
            this.Controls.Add(this.txtYinicial);
            this.Controls.Add(this.txtXfinal);
            this.Controls.Add(this.txtXinicial);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.lblYinicil);
            this.Controls.Add(this.lblXfinal);
            this.Controls.Add(this.lblXinicial);
            this.Name = "fmrLinea";
            this.Text = "Dibujar Linea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblXfinal;
        private System.Windows.Forms.Label lblYinicil;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.TextBox txtXinicial;
        private System.Windows.Forms.TextBox txtXfinal;
        private System.Windows.Forms.TextBox txtYinicial;
        private System.Windows.Forms.TextBox txtYfinal;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.Label lblCantidadDeLineas;
        private System.Windows.Forms.TextBox txtCantidadDeLineas;
    }
}

