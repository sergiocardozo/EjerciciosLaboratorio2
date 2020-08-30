using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Duracion de la llamada: {this.Duracion}"));
            sb.AppendLine(string.Format($"Numero de Origen: {this.NroOrigen}"));
            sb.AppendLine(string.Format($"Numero de Destino: {this.NroDestino}"));
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.duracion)
                return 1;
            if (llamada1.Duracion == llamada2.duracion)
                return 0;
            else
                return -1;
        }
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
    }
}
