using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;
namespace NotePad
{
    public partial class FormNotepad : Form
    {
        string path = null;
        public FormNotepad()
        {
            InitializeComponent();
            toolStripStatusLabelCaracteres.Text = "0 Caracteres";
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelCaracteres.Text = (rtbTexto.Text.Count<char>()).ToString() + "Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.HideDropDown();
            this.Abrir();
            rtbTexto.Focus();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.HideDropDown();
            if (this.path == null)
                GuardarComo();
            else
            {
                if (Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto = new PuntoTxt();
                    texto.Guardar(this.path, rtbTexto.Text);
                }
                else if (Path.GetExtension(this.path) == ".dat")
                {
                    PuntoDat binario = new PuntoDat();
                    binario.Contenido = rtbTexto.Text;
                    binario.GuardarComo(this.path, binario);
                }
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.HideDropDown();
            GuardarComo();
        }        
        public void GuardarComo()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = (this.path == null) ? AppDomain.CurrentDomain.BaseDirectory : this.path;
            dialog.Filter = "Archivos de texto (.txt)|*.txt|Archivos de datos (.dat)|*.dat";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.path = dialog.FileName;
                if (Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto = new PuntoTxt();
                    texto.GuardarComo(this.path, rtbTexto.Text);
                }
                else if (Path.GetExtension(this.path) == ".dat")
                {
                    PuntoDat binario = new PuntoDat();
                    binario.Contenido = rtbTexto.Text;
                    binario.GuardarComo(this.path, binario);
                }
            }
        }
        public void Abrir()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = (this.path == null) ? AppDomain.CurrentDomain.BaseDirectory : this.path;
            dialog.Filter = "Archivos de texto (.txt)|*.txt|Archivos de datos (.dat)|*.dat";

            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.path = dialog.FileName;
                if (Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto = new PuntoTxt();
                    rtbTexto.Text = texto.Leer(this.path);
                }
                else if (Path.GetExtension(this.path) == ".dat")
                {
                    PuntoDat binario = new PuntoDat();
                    binario = binario.Leer(this.path);
                    rtbTexto.Text = binario.Contenido;
                }
            }

        }

    }
}
