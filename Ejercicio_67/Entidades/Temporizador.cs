using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Entidades
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo;
         
        /// <summary>
        /// Propiedad Si esta activo true se inicial el hilo siempre que no este activo
        /// Propiedad Si el estado activo es false se detendra el hilo siempre y cuando este activo
        /// </summary>
        public bool Activo 
        {
            get { return (this.hilo != null && this.hilo.IsAlive); }
            set
            {
                if(value == true)//si el valor es true
                {
                    if(this.hilo == null || !this.hilo.IsAlive)//si el hilo no existe o no se este ejecutando
                    {
                        hilo = new Thread(Corriendo);//inicializo el hilo
                        hilo.Start();
                    }
                }
                else
                {
                    if (this.hilo != null && this.hilo.IsAlive)//si el hilo existe y esta corriendo
                        this.hilo.Abort();//inicia el proceso de finalizacion del hilo
                }
            }
        }
        /// <summary>
        /// Propiedad que determina cada cuanto tiempo en milisegundos se lanzara el evento
        /// </summary>
        public int Intervalo
        {
            get { return intervalo / 1000; }
            set { this.intervalo = value * 1000; }
        }
        /// <summary>
        /// Metodo que hace la demora (Intervalo) y lanza el evento EventoTiempo
        /// </summary>
        private void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(intervalo);
                this.EventoTiempo();
            }
        }
    }
}
