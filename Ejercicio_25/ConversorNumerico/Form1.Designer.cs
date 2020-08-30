namespace ConversorNumerico
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.txtBinarioIn = new System.Windows.Forms.TextBox();
            this.txtDecimalIn = new System.Windows.Forms.TextBox();
            this.txtBinDecOut = new System.Windows.Forms.TextBox();
            this.txtDecBinOut = new System.Windows.Forms.TextBox();
            this.btnConvertirBin = new System.Windows.Forms.Button();
            this.btnConvertirDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(13, 18);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(90, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario A Decimal";
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(13, 53);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalBinario.TabIndex = 1;
            this.lblDecimalBinario.Text = "Decimal a Binario";
            // 
            // txtBinarioIn
            // 
            this.txtBinarioIn.Location = new System.Drawing.Point(109, 14);
            this.txtBinarioIn.Name = "txtBinarioIn";
            this.txtBinarioIn.Size = new System.Drawing.Size(132, 20);
            this.txtBinarioIn.TabIndex = 2;
            this.txtBinarioIn.Click += new System.EventHandler(this.txtBinarioIn_Click);
            this.txtBinarioIn.Leave += new System.EventHandler(this.txtBinIn_leave);
            // 
            // txtDecimalIn
            // 
            this.txtDecimalIn.Location = new System.Drawing.Point(108, 49);
            this.txtDecimalIn.Name = "txtDecimalIn";
            this.txtDecimalIn.Size = new System.Drawing.Size(133, 20);
            this.txtDecimalIn.TabIndex = 3;
            this.txtDecimalIn.Leave += new System.EventHandler(this.txtDecIn);
            // 
            // txtBinDecOut
            // 
            this.txtBinDecOut.Location = new System.Drawing.Point(328, 15);
            this.txtBinDecOut.Name = "txtBinDecOut";
            this.txtBinDecOut.Size = new System.Drawing.Size(132, 20);
            this.txtBinDecOut.TabIndex = 4;
            // 
            // txtDecBinOut
            // 
            this.txtDecBinOut.Location = new System.Drawing.Point(328, 49);
            this.txtDecBinOut.Name = "txtDecBinOut";
            this.txtDecBinOut.Size = new System.Drawing.Size(132, 20);
            this.txtDecBinOut.TabIndex = 5;
            // 
            // btnConvertirBin
            // 
            this.btnConvertirBin.Location = new System.Drawing.Point(247, 14);
            this.btnConvertirBin.Name = "btnConvertirBin";
            this.btnConvertirBin.Size = new System.Drawing.Size(75, 20);
            this.btnConvertirBin.TabIndex = 6;
            this.btnConvertirBin.Text = "->";
            this.btnConvertirBin.UseVisualStyleBackColor = true;
            this.btnConvertirBin.Click += new System.EventHandler(this.btnConvertirBin_Click);
            // 
            // btnConvertirDec
            // 
            this.btnConvertirDec.Location = new System.Drawing.Point(247, 48);
            this.btnConvertirDec.Name = "btnConvertirDec";
            this.btnConvertirDec.Size = new System.Drawing.Size(75, 20);
            this.btnConvertirDec.TabIndex = 7;
            this.btnConvertirDec.Text = "->";
            this.btnConvertirDec.UseVisualStyleBackColor = true;
            this.btnConvertirDec.Click += new System.EventHandler(this.btnConvertirDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 132);
            this.Controls.Add(this.btnConvertirDec);
            this.Controls.Add(this.btnConvertirBin);
            this.Controls.Add(this.txtDecBinOut);
            this.Controls.Add(this.txtBinDecOut);
            this.Controls.Add(this.txtDecimalIn);
            this.Controls.Add(this.txtBinarioIn);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox txtBinarioIn;
        private System.Windows.Forms.TextBox txtDecimalIn;
        private System.Windows.Forms.TextBox txtBinDecOut;
        private System.Windows.Forms.TextBox txtDecBinOut;
        private System.Windows.Forms.Button btnConvertirBin;
        private System.Windows.Forms.Button btnConvertirDec;
    }
}

