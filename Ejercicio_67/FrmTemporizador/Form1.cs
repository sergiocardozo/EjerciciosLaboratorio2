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

namespace FrmTemporizador
{
    public partial class FrmTemporizador : Form
    {
        Temporizador temporizador = new Temporizador();
        /// <summary>
        /// Inicializa los componentes del form
        /// Asocia EventoTiempo al metodo ActualizarLabel
        /// Define el intervalo del temporizador en 1 segundo
        /// </summary>
        public FrmTemporizador()
        {
            InitializeComponent();
            temporizador.EventoTiempo += ActualizarLabel;
            temporizador.Intervalo = 1;
        }
        /// <summary>
        /// Al abrir el formulario paso el estado del temporizador Activo true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTemporizador_Load(object sender, EventArgs e)
        {
            temporizador.Activo = true;
        }
        /// <summary>
        /// Metodo que imprime la hora y fecha actual en un label
        /// </summary>
        private void ActualizarLabel()
        {
            if(this.labelTiempo.InvokeRequired)
            {
                Temporizador.encargadoTiempo callBack = new Temporizador.encargadoTiempo(this.ActualizarLabel);
                this.labelTiempo.Invoke(callBack);
            }
            else
            {
                this.labelTiempo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
        /// <summary>
        /// Al cerrar el formulario paso el estado Activo a false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTemporizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Activo = false;
        }

    }
}
