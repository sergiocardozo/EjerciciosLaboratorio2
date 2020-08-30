using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CentralTelefonica
{
    public partial class FrmMenu : Form
    {
        Centralita centralita = new Centralita();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(centralita.Leer(), "Log Llamadas");
            this.Close();
        }
    }
}
