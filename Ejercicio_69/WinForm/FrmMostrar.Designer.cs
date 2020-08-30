namespace WinForm
{
    partial class FrmMostrar
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
            this.labelEtiqueta = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEtiqueta
            // 
            this.labelEtiqueta.AutoSize = true;
            this.labelEtiqueta.Location = new System.Drawing.Point(12, 9);
            this.labelEtiqueta.Name = "labelEtiqueta";
            this.labelEtiqueta.Size = new System.Drawing.Size(61, 13);
            this.labelEtiqueta.TabIndex = 0;
            this.labelEtiqueta.Text = "ETIQUETA";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 36);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(421, 249);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 297);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.labelEtiqueta);
            this.Name = "FrmMostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEtiqueta;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
    }
}