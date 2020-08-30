using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmMostrar : Form
    {
        public delegate void ActualizarNombreDelegado(string dato);
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public void ActualizarNombre(string dato)
        {
            labelEtiqueta.Text = dato;
        }
        public void ActualizarFoto(string archivo)
        {
            this.pictureBoxImagen.ImageLocation = archivo;
            
        }
    }

}
