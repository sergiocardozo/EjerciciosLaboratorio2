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
    public partial class FrmPrincipal : Form
    {        
        FrmTestDelegados frmTest;
        FrmMostrar frmMostrar;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest = new FrmTestDelegados();
            frmTest.MdiParent = this;
            mostrarToolStripMenuItem.Enabled = true;
            frmTest.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTest.ButtonActualizar += frmMostrar.ActualizarNombre;
            frmTest.ButtonActualizarImagen += frmMostrar.ActualizarFoto;
            frmMostrar.Show();
        }
    }
}
