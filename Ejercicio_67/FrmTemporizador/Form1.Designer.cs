namespace FrmTemporizador
{
    partial class FrmTemporizador
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
            this.rtbQueNoHaceNada = new System.Windows.Forms.RichTextBox();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbQueNoHaceNada
            // 
            this.rtbQueNoHaceNada.Location = new System.Drawing.Point(12, 52);
            this.rtbQueNoHaceNada.Name = "rtbQueNoHaceNada";
            this.rtbQueNoHaceNada.Size = new System.Drawing.Size(408, 282);
            this.rtbQueNoHaceNada.TabIndex = 0;
            this.rtbQueNoHaceNada.Text = "";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(12, 9);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(66, 24);
            this.labelTiempo.TabIndex = 1;
            this.labelTiempo.Text = "label1";
            // 
            // FrmTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 346);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.rtbQueNoHaceNada);
            this.Name = "FrmTemporizador";
            this.Text = "Temporizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTemporizador_FormClosing);
            this.Load += new System.EventHandler(this.FrmTemporizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQueNoHaceNada;
        private System.Windows.Forms.Label labelTiempo;
    }
}

