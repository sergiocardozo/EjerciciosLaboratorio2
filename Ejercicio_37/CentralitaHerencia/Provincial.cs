using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()}"));
            sb.AppendLine(string.Format($"Costo de la llamada: {this.CostoLlamada:C}"));
            sb.AppendLine(string.Format($"Franja horaria: {this.franjaHoraria}"));
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.Duracion * (float)0.99;                    
                case Franja.Franja_2:
                    return this.Duracion * (float)1.25;
                case Franja.Franja_3:
                    return this.Duracion * (float)0.66;
                default:
                    return 0;
            }
        }
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
    }
}
