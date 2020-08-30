namespace NotePad
{
    partial class FormNotepad
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
            this.menuStripArchivos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripCaracteres = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.menuStripArchivos.SuspendLayout();
            this.statusStripCaracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripArchivos
            // 
            this.menuStripArchivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStripArchivos.Location = new System.Drawing.Point(0, 0);
            this.menuStripArchivos.Name = "menuStripArchivos";
            this.menuStripArchivos.Size = new System.Drawing.Size(629, 24);
            this.menuStripArchivos.TabIndex = 0;
            this.menuStripArchivos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.ToolTipText = "Ctrl+A";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.ToolTipText = "Ctrl+S";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
            this.guardarComoToolStripMenuItem.ToolTipText = "Ctrl+Mayús.+S";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // statusStripCaracteres
            // 
            this.statusStripCaracteres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCaracteres});
            this.statusStripCaracteres.Location = new System.Drawing.Point(0, 380);
            this.statusStripCaracteres.Name = "statusStripCaracteres";
            this.statusStripCaracteres.Size = new System.Drawing.Size(629, 22);
            this.statusStripCaracteres.TabIndex = 1;
            this.statusStripCaracteres.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCaracteres
            // 
            this.toolStripStatusLabelCaracteres.Name = "toolStripStatusLabelCaracteres";
            this.toolStripStatusLabelCaracteres.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelCaracteres.Text = "toolStripStatusLabel1";
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Location = new System.Drawing.Point(0, 24);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(629, 356);
            this.rtbTexto.TabIndex = 2;
            this.rtbTexto.Text = "";
            this.rtbTexto.TextChanged += new System.EventHandler(this.rtbTexto_TextChanged);
            // 
            // FormNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 402);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.statusStripCaracteres);
            this.Controls.Add(this.menuStripArchivos);
            this.MainMenuStrip = this.menuStripArchivos;
            this.Name = "FormNotepad";
            this.Text = "Ej56";
            this.menuStripArchivos.ResumeLayout(false);
            this.menuStripArchivos.PerformLayout();
            this.statusStripCaracteres.ResumeLayout(false);
            this.statusStripCaracteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripArchivos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripCaracteres;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCaracteres;
    }
}

