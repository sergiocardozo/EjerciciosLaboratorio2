using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HoraActualizada
{
    public partial class Form1 : Form
    {
        private Thread hilo;
        private delegate void CallBack(object o);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hilo = new Thread(new ThreadStart(AsignarHora));
            hilo.Start();
            timer1.Enabled = true;
            //this.AsignarHora();
        }

        private void AsignarHora()
        {
            String hora;
            while(true)
            {
                hora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                ActualizarLabel(hora);
                Thread.Sleep(1000);
            }
        }
        private void ActualizarLabel(object o)
        {
            if(this.label1.InvokeRequired)
            {
                object[] parametros = new object[] { o };
                CallBack cB = new CallBack(this.ActualizarLabel);
                this.label1.Invoke(cB, parametros);
            }
            else
            {
                this.label1.Text = (string)o;
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo != null && this.hilo.IsAlive)
                this.hilo.Abort();
        }

    }
}
