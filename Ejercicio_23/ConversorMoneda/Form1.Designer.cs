namespace ConversorMoneda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEuroIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.BtnConvertirPeso = new System.Windows.Forms.Button();
            this.txtPesosIn = new System.Windows.Forms.TextBox();
            this.txtDolarIn = new System.Windows.Forms.TextBox();
            this.txtCotPeso = new System.Windows.Forms.TextBox();
            this.txtCotDolar = new System.Windows.Forms.TextBox();
            this.txtCotEuro = new System.Windows.Forms.TextBox();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEuroIn
            // 
            this.txtEuroIn.Location = new System.Drawing.Point(84, 94);
            this.txtEuroIn.Name = "txtEuroIn";
            this.txtEuroIn.Size = new System.Drawing.Size(100, 20);
            this.txtEuroIn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 171);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cotizacion";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 71);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 71);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 71);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Euro";
            // 
            // btnLock
            // 
            this.btnLock.ImageIndex = 1;
            this.btnLock.ImageList = this.imageList1;
            this.btnLock.Location = new System.Drawing.Point(194, 32);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 0;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock-open-solid.png");
            this.imageList1.Images.SetKeyName(1, "lock-solid.png");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(194, 92);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 5;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(194, 135);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirDolar.TabIndex = 10;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // BtnConvertirPeso
            // 
            this.BtnConvertirPeso.Location = new System.Drawing.Point(194, 171);
            this.BtnConvertirPeso.Name = "BtnConvertirPeso";
            this.BtnConvertirPeso.Size = new System.Drawing.Size(75, 23);
            this.BtnConvertirPeso.TabIndex = 15;
            this.BtnConvertirPeso.Text = "->";
            this.BtnConvertirPeso.UseVisualStyleBackColor = true;
            this.BtnConvertirPeso.Click += new System.EventHandler(this.BtnConvertirPeso_Click);
            // 
            // txtPesosIn
            // 
            this.txtPesosIn.Location = new System.Drawing.Point(84, 173);
            this.txtPesosIn.Name = "txtPesosIn";
            this.txtPesosIn.Size = new System.Drawing.Size(100, 20);
            this.txtPesosIn.TabIndex = 14;
            this.txtPesosIn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDolarIn
            // 
            this.txtDolarIn.Location = new System.Drawing.Point(84, 135);
            this.txtDolarIn.Name = "txtDolarIn";
            this.txtDolarIn.Size = new System.Drawing.Size(100, 20);
            this.txtDolarIn.TabIndex = 9;
            // 
            // txtCotPeso
            // 
            this.txtCotPeso.Location = new System.Drawing.Point(499, 31);
            this.txtCotPeso.Name = "txtCotPeso";
            this.txtCotPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotPeso.TabIndex = 3;
            this.txtCotPeso.Leave += new System.EventHandler(this.txtCotizPesos_Leave);
            // 
            // txtCotDolar
            // 
            this.txtCotDolar.Location = new System.Drawing.Point(391, 31);
            this.txtCotDolar.Name = "txtCotDolar";
            this.txtCotDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotDolar.TabIndex = 2;
            this.txtCotDolar.Leave += new System.EventHandler(this.txtCotizDolar_leave);
            // 
            // txtCotEuro
            // 
            this.txtCotEuro.Location = new System.Drawing.Point(284, 31);
            this.txtCotEuro.Name = "txtCotEuro";
            this.txtCotEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotEuro.TabIndex = 1;
            this.txtCotEuro.Leave += new System.EventHandler(this.txtCotEuro_Leave);
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Location = new System.Drawing.Point(284, 97);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroEuro.TabIndex = 6;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Location = new System.Drawing.Point(284, 135);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarEuro.TabIndex = 11;
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Location = new System.Drawing.Point(284, 174);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoEuro.TabIndex = 16;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Location = new System.Drawing.Point(391, 97);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroDolar.TabIndex = 7;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Location = new System.Drawing.Point(391, 135);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarDolar.TabIndex = 12;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Location = new System.Drawing.Point(391, 173);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoDolar.TabIndex = 17;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Location = new System.Drawing.Point(500, 97);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroPeso.TabIndex = 8;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Location = new System.Drawing.Point(500, 135);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarPeso.TabIndex = 13;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Location = new System.Drawing.Point(501, 174);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoPeso.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 224);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.txtCotEuro);
            this.Controls.Add(this.txtCotDolar);
            this.Controls.Add(this.txtCotPeso);
            this.Controls.Add(this.txtDolarIn);
            this.Controls.Add(this.txtPesosIn);
            this.Controls.Add(this.BtnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEuroIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEuroIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Button BtnConvertirPeso;
        private System.Windows.Forms.TextBox txtPesosIn;
        private System.Windows.Forms.TextBox txtDolarIn;
        private System.Windows.Forms.TextBox txtCotPeso;
        private System.Windows.Forms.TextBox txtCotDolar;
        private System.Windows.Forms.TextBox txtCotEuro;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtPesoPeso;
        private System.Windows.Forms.ImageList imageList1;
    }
}

