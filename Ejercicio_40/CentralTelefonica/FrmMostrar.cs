using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CentralTelefonica
{
    public partial class FrmMostrar : Form
    {
        public Centralita centralita;
        public Local local;
        public Provincial provincial;
        private Llamada.TipoLlamada tipoLlamada;
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
        public Llamada.TipoLlamada FacturarTipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
                this.CalcularGanancia(value);
            }
        }
        public void CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            //float acumulado;
            this.centralita.OrdenarLlamadas();
            switch (tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    rtbMostrar.Text = String.Format($"Ganancia por Local: {this.centralita.GananciasPorLocal}");
                    break;
                case Llamada.TipoLlamada.Provincial:
                    rtbMostrar.Text = String.Format($"Ganacia por Provincial: {this.centralita.GananciasPorProvincial}");
                    break;
                case Llamada.TipoLlamada.Todas:
                default:
                    rtbMostrar.Text = String.Format($"{this.centralita.Mostrar()}");
                    break;
            }
        }
    }
}
