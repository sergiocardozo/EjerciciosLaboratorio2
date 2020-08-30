using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.ActualizarNombreDelegado ButtonActualizar;
        public event FrmMostrar.ActualizarNombreDelegado ButtonActualizarImagen;
        private string imagePath;

        public FrmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.ButtonActualizar.Invoke(textBoxTestDelegados.Text);
            this.ButtonActualizarImagen.Invoke(this.imagePath);

        }

       

        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Imagenes|*.jpg;*.gif;*.png;|Todos|*.*";
            this.openFileDialog.Multiselect = false;
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = this.openFileDialog.FileName;
            }
        }
    }
}
