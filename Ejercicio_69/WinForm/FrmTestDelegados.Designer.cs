namespace WinForm
{
    partial class FrmTestDelegados
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
            this.textBoxTestDelegados = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBuscarFoto = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxTestDelegados
            // 
            this.textBoxTestDelegados.Location = new System.Drawing.Point(12, 12);
            this.textBoxTestDelegados.Multiline = true;
            this.textBoxTestDelegados.Name = "textBoxTestDelegados";
            this.textBoxTestDelegados.Size = new System.Drawing.Size(287, 27);
            this.textBoxTestDelegados.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(12, 45);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(287, 53);
            this.buttonActualizar.TabIndex = 1;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonBuscarFoto
            // 
            this.buttonBuscarFoto.Location = new System.Drawing.Point(12, 104);
            this.buttonBuscarFoto.Name = "buttonBuscarFoto";
            this.buttonBuscarFoto.Size = new System.Drawing.Size(287, 53);
            this.buttonBuscarFoto.TabIndex = 2;
            this.buttonBuscarFoto.Text = "Buscar Foto";
            this.buttonBuscarFoto.UseVisualStyleBackColor = true;
            this.buttonBuscarFoto.Click += new System.EventHandler(this.buttonBuscarFoto_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FrmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 165);
            this.Controls.Add(this.buttonBuscarFoto);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxTestDelegados);
            this.Name = "FrmTestDelegados";
            this.Text = "Test Delegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTestDelegados;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBuscarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}