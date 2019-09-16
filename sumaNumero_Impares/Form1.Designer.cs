namespace sumaNumero_Impares
{
    partial class Form1
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblsumaimpares = new System.Windows.Forms.Label();
            this.lblimparessuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(56, 34);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(369, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "suma de los primeros numero impares";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(183, 114);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(129, 22);
            this.txtnumero.TabIndex = 1;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(334, 117);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(91, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(34, 117);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(143, 16);
            this.lblnumero.TabIndex = 3;
            this.lblnumero.Text = "Ingrese un numero :";
            // 
            // lblsumaimpares
            // 
            this.lblsumaimpares.AutoSize = true;
            this.lblsumaimpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsumaimpares.Location = new System.Drawing.Point(141, 199);
            this.lblsumaimpares.Name = "lblsumaimpares";
            this.lblsumaimpares.Size = new System.Drawing.Size(51, 16);
            this.lblsumaimpares.TabIndex = 6;
            this.lblsumaimpares.Text = "Suma:";
            // 
            // lblimparessuma
            // 
            this.lblimparessuma.AutoSize = true;
            this.lblimparessuma.Location = new System.Drawing.Point(198, 199);
            this.lblimparessuma.Name = "lblimparessuma";
            this.lblimparessuma.Size = new System.Drawing.Size(49, 13);
            this.lblimparessuma.TabIndex = 7;
            this.lblimparessuma.Text = "impares+";
            this.lblimparessuma.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.lblimparessuma);
            this.Controls.Add(this.lblsumaimpares);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblsumaimpares;
        private System.Windows.Forms.Label lblimparessuma;
    }
}

